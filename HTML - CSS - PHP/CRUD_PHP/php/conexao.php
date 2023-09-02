<?php 

    $host = "localhost";
    $usuario_banco = "root";
    $senha_banco = "";
    $banco = "estudos";

    try{
        $con = mysqli_connect($host, $usuario_banco, $senha_banco, $banco);
    }catch(mysqli_sql_exception $e){
        die("Não foi possível se conectar ao banco: ".mysqli_error($con));
    }
?>
