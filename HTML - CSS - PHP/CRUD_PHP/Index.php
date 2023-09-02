<?php 
    session_start();

    if(isset($_SESSION["loginCliente"])){ unset( $_SESSION["loginCliente"]);}
    if(isset($_SESSION["senhaCliente"])){ unset( $_SESSION["senhaCliente"]); }
    if(isset($_SESSION["senhaCliente"])){ unset( $_SESSION["senhaCliente"]); }
    if(isset($_SESSION["idCliente"])){ unset( $_SESSION["idCliente"]); }
    if(isset($_SESSION["nomeCliente"])){ unset( $_SESSION["nomeCliente"]); }
    if(isset($_SESSION["cpfCliente"])){ unset( $_SESSION["cpfCliente"]); }
    if(isset($_SESSION["hierarquiaCliente"])){ unset( $_SESSION["hierarquiaCliente"]); }
    if(isset($_SESSION["telefoneCliente"])){ unset( $_SESSION["telefoneCliente"]); }
    if(isset($_SESSION["data_addCliente"])){ unset( $_SESSION["data_addCliente"]); }
    if(isset($_SESSION["emailCliente"])){ unset( $_SESSION["emailCliente"]); }

?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="CSS/login.css" type="text/css">
    <link rel="shortcut icon" href="imagens/icone_crud.png" type="image/x-icon">
    <title>Login</title>
</head>
<body>
    <main>
        <div id="login">
            <img src="imagens/do-utilizador.png" alt="">
            
            <p id="mensagemErro"><?php
                
                $mensagem = isset($_SESSION['mensagem']) ? $_SESSION['mensagem'] : '';

                if($mensagem != "")
                {
                    echo $mensagem;
                
                }
                session_destroy();
                
            ?></p> 

            <div id="form_login">
                <form action="php/login.php" method="POST">
                    <input type="text" name="login" placeholder="Informe seu Login"> <br>
                    <input type="password" name="senha" placeholder="Informe sua Senha">  <br>

                    <br>
                    <input type="submit" value="ENTRAR">
                </form>
            </div>

            <a id="cadastrar" href="paginas/cadastro_cliente.php">Não é cliente? realize o seu cadastro agora!</a>
        </div>
    </main>

    <footer>
    <div id="conhecer_criador"><a href="https://github.com/JaoVitorPeixoto" target="_blank"><img width="25px" id="imgGithub" src="imagens/github.png">Conhecer Criador</a></div>
        <p>© DESENVOLVIDO POR JOÃO VITOR FERREIRA PEIXOTO</p>
        <p>4º ANO DO CURSO TÉCNICO EM INFORMÁTICA</p>
        <p>IFBA CAMPUS CAMAÇARI</p>
    </footer>
</body>
</html>