<?php
    include("../php/conexao.php");
    include("../php/validacao_hierarquia.php");

    $id = $_POST["idAP"];

    $cliente = mysqli_query($con, "SELECT * FROM cliente WHERE id='$id'");

    mysqli_close($con);
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="shortcut icon" href="../imagens/icone_crud.png" type="image/x-icon">
    <title>Deletar</title>
</head>
<body>

    <form action="../php/delete.php" method="POST">
        <?php if($validacao_hierarquia == true){ echo "<p>Tem Certeza que Deseja Apagar o Cliente?</p>"; }else{ echo "<p>Você não tem permissão para deletar Clientes, entre com o usário ADM: login='adm' e senha='1234'</p>"; } ?>

            <?php while($linha=mysqli_fetch_array($cliente)) {?>
                <input type="hidden" name="id" value="<?=$id?>">
                NOME:<input type="text" name="nome" size="60" value="<?=$linha["nome"]?>" disabled="disable"> <br>
                CPF:<input type="text" name="cpf" size="11" maxlength="11" value="<?=$linha["cpf"]?>" disabled="disable"> <br>
            <?php } ?>
            <br>
            <input type="submit" value="APAGAR" <?php if($validacao_hierarquia == false){ echo 'disabled = "disable"';} ?>>
    </form>

    <br>
    <a href="home.php"><button>VOLTAR</button></a>   

</body>
</html>