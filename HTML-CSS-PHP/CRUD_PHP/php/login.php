<?php
    session_start();
    include("conexao.php");

    $login = $_POST["login"];
    $senha = $_POST["senha"];

    $result = mysqli_query($con, "SELECT * FROM cliente WHERE `login`='$login' AND `senha`='$senha'");

    $linha = mysqli_num_rows($result);
    if($linha > 0){

       while($row = mysqli_fetch_array($result)){
            $_SESSION["loginCliente"] = $login;
            $_SESSION["senhaCliente"] = $senha;
            $_SESSION["idCliente"] = $row["id"];
            $_SESSION["nomeCliente"] = $row["nome"];
            $_SESSION["cpfCliente"] = $row["cpf"];
            $_SESSION["hierarquiaCliente"] = $row["hierarquia"];
            $_SESSION["telefoneCliente"] = $row["telefone"];
            $_SESSION["data_addCliente"] = $row["data_adicionado"];
            $_SESSION["emailCliente"] = $row["email"]; 
        }

        header('location:../paginas/home.php');
        
    }else{
        $_SESSION["mensagem"] = "Usuário ou senha incorretos!!";
        header('location:../index.php');        
    }
?>