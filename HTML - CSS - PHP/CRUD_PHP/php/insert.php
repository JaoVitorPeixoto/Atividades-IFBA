<?php
        include("conexao.php");
        include("validacao_hierarquia.php");

        $login = $_POST["login"];
        $senha = $_POST["senha"];
        $nome = $_POST["nome"];
        $cpf = $_POST["cpf"];
        $hierarquia = $_POST["hierarquia"];
        $telefone = $_POST["telefone"];
        $email = $_POST["email"];
        
        try{
            mysqli_query($con, "INSERT INTO cliente(`login`, senha, nome, cpf, hierarquia, telefone, email) VALUES('$login', '$senha', '$nome', '$cpf', '$hierarquia', '$telefone', '$email')");
            echo("<p>Dados inseridos com sucesso!!</p>");
            if(isset($validacao_hierarquia) and $validacao_hierarquia == true){ header("Location:../paginas/home.php"); }else{ header("Location:../index.php"); }
        }catch(Exception $e){
            echo("Erro ao inserir dados no banco: ".$e);
        }

        
?>