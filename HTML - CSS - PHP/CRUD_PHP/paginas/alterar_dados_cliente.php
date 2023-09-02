<?php
    include("../php/conexao.php");
    include("../php/validacao_hierarquia.php");

    $id = $_POST["idAL"];

    $cliente = mysqli_query($con, "SELECT * FROM cliente WHERE id='$id'");

    mysqli_close($con);
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="shortcut icon" href="../imagens/icone_crud.png" type="image/x-icon">
    <title>Dados do Cliente</title>
</head>
<body>  
            
    <h1>ALTERAR DADOS DO CLIENTE</h1>
    <br>
    <?php if($validacao_hierarquia == false){ echo "Você não possui permissão para alterar os dados dos clientes, entre com o usário ADM: login='adm' e senha='1234'"; } ?>

    <form action="../php/update.php" method="POST">
        <?php while($linha=mysqli_fetch_array($cliente)) {?>

            <input type="hidden" name="id" value="<?=$id?>">
            LOGIN:<input type="text" name="login" value="<?=$linha["login"]?>" disabled="disable"> <select <?php if($validacao_hierarquia == true){ echo "style='visibility: visible;' "; } else{ echo "style='visibility: hidden;' "; } ?> id='hierarquia' name="hierarquia" required><option value='Cliente' <?php if($linha["hierarquia"] == "Cliente"){ echo "selected='selected'"; } ?>>Cliente</option> <option value='ADM' <?php if($linha["hierarquia"] == "ADM"){ echo "selected='selected'"; echo "selected='selected'"; } ?>>Administrador</option></select> <br>
            SENHA:<input type="password" name="senha" value="<?=$linha["senha"]?>"> <br>
            NOME:<input type="text" name="nome" size="60" value="<?=$linha["nome"]?>"> <br>
            TELEFONE:<input type="text" name="telefone" size="14" value="<?=$linha["telefone"]?>"> <br>
            E-MAIL:<input type="text" name="email" size="50" value="<?=$linha["email"]?>"> <br>
            CPF:<input type="text" name="cpf" size="11" maxlength="11" value="<?=$linha["cpf"]?>"> <br>
        <?php } ?>
        <br>
        <input type="submit" value="SALVAR" <?php if($validacao_hierarquia == false){ echo "disabled='disable'";} ?>>
    </form>

    <a href="home.php"><button>VOLTAR</button></a>
</body>
</html>