<?php 
    include("../php/validacao_hierarquia.php");
?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="../CSS/cadastrar.css" type="text/css">
    <link rel="shortcut icon" href="../imagens/icone_crud.png" type="image/x-icon">
    <link rel="stylesheet" href="../CSS/home.css" type="text/css">
    <title>Cadastrar Cliente</title>
</head>
<body>
    
    <?php if(isset($validacao_hierarquia)){ ?>

        <header>
            <div id="logo"><img src="../imagens/logo.png" alt="Logo" width="100%"></div>
            <nav>
                <a id="gitHub" href="https://github.com/JaoVitorPeixoto" target="_blank"><img width="25px" id="imgGithub" src="../imagens/github.png">Conhecer Criador</a>
                <a href="cadastro_cliente.php">Ver Perfil</a>
                <a href="../index.php">Fazer Logoff</a>
            </nav>
        </header>
        
    <?php } ?>
    
    <main>
        <div id="form_cadastro">
        <h1>CADASTRO DE CLIENTE</h1>
                <?php if(isset($validacao_hierarquia) and $validacao_hierarquia == false){ echo "<p>Você não possui permissão para criar um Usuário novo, entre com o usário ADM: login='adm' e senha='1234'</p>"; } ?>
                <form action="../php/insert.php" method="POST">
                    <input type="text" name="login" size="30" placeholder="LOGIN" required>  
                    <input type="password" name="senha" size="30" placeholder="SENHA" required> <br>
                    <input type="text" name="nome" size="60" placeholder="NOME" required> <br>
                    <input type="tel" name="telefone" size="14" placeholder="TELEFONE" required> <br>
                    <input type="email" name="email" size="50" placeholder="E-MAIL" required> <br>
                    <input type="text" name="cpf" size="11" maxlength="11" placeholder="CPF" required> <br>
                    <select <?php if($validacao_hierarquia == true){ echo "style='visibility: visible;' "; } else{ echo "style='visibility: hidden;'"; } ?> id='hierarquia' name="hierarquia" required><option value="Cliente">Cliente</option> <option value='ADM'>Administrador</option></select> <br>
                    <br>
                    <input type="submit" id="btnSalvar" value="Salvar" <?php if(isset($validacao_hierarquia) and $validacao_hierarquia == false){ echo "disabled='disable'"; } ?>>
                    <input type="reset" value="Limpar">
                    
                </form>
        </div>

        <div id="select"><a href="<?php if(isset($validacao_hierarquia)){ echo "home.php"; }else{ echo "../index.php"; } ?>" id="btnVoltar"><button>VOLTAR</button></a></div>
    </main>

    <footer>
        <p>© DESENVOLVIDO POR JOÃO VITOR FERREIRA PEIXOTO</p>
        <p>4º ANO DO CURSO TÉCNICO EM INFORMÁTICA</p>
        <p>IFBA CAMPUS CAMAÇARI</p>
    </footer>
</body>
</html>