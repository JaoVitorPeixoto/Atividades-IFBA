<?php
    include("conexao.php");
    include("validacao_hierarquia.php");

    $id = $_POST["id"];
    

    if($validacao_hierarquia == true){
        try{
            mysqli_query($con, "DELETE FROM cliente WHERE id='$id'");
            echo("<p>Cliente deletado com sucesso!!</p>");
            header("Location:../paginas/home.php");
        }catch(Exception $e){
            echo("Erro ao deletar cliente no banco: ".$e);
        }
    } else{
        echo "<p>Você não tem permissão para apagar um Usuário</p>";
    }       
?>