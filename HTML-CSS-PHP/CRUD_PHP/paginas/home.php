
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="../CSS/home.css" type="text/css">
    <link rel="shortcut icon" href="../imagens/icone_crud.png" type="image/x-icon">
    <title>HOME</title>
</head>
<body>
    <?php
    include("../php/conexao.php");
        session_start();

        $clientes = mysqli_query($con, "SELECT * FROM cliente"); 
        
        mysqli_close($con);
    ?>

    <header>
        <div id="logo"><img src="../imagens/logo.png" alt="Logo" width="100%"></div>
        <nav>
            <a id="gitHub" href="https://github.com/JaoVitorPeixoto" target="_blank"><img width="25px" id="imgGithub" src="../imagens/github.png">Conhecer Criador</a>
            <a href="ver_perfil.php">Ver Perfil</a>
            <a href="../Index.php">Fazer Logoff</a>
        </nav>
    </header>

    <main>
        
        <div id="tbl_clientes" >
            <table>
                <tr>
                    
                    <th>NOME</th>
                    <th>CPF</th>
                    <th>TELEFONE</th>
                    <th>E-MAIL</th>
                    <th>DATA ADICIONADO</th>
                    <th>AÇÕES</th>
        
                </tr>
                
                <?php while($linha = mysqli_fetch_array($clientes)){ ?>
                    <tr>
                        
                        <td><?=$linha["nome"]?></td>
                        <td><?=$linha["cpf"]?></td>
                        <td><?=$linha["telefone"]?></td>
                        <td><?=$linha["email"]?></td>
                        <td><?=$linha["data_adicionado"]?></td>         
                        <td style="height: 60px; text-align: center;"><form action="alterar_dados_cliente.php" method="POST"><input type="hidden" name="idAL" value="<?=$linha["id"]?>"> <input class="hover" id="btnAlterar" type="submit" value="ALTERAR"></form><form action="deletar.php" method="POST"><input class="hover" type="hidden" name="idAP" value="<?=$linha["id"]?>"> <input id="btnApagar" type="submit" value="APAGAR"></form></td>
                    </tr>
                <?php } ?>

            </table>
        </div>

        <a id="btnCadastrarCliente"href="cadastro_cliente.php"><button>CADASTRAR CLIENTE</button></a>
    </main>

    <footer>
        <p>© DESENVOLVIDO POR JOÃO VITOR FERREIRA PEIXOTO</p>
        <p>4º ANO DO CURSO TÉCNICO EM INFORMÁTICA</p>
        <p>IFBA CAMPUS CAMAÇARI</p>
    </footer>
</body>
</html>