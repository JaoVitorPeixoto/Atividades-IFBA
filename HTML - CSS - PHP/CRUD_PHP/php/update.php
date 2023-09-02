 <?php
    include("conexao.php");

        $id = $_POST["id"];
        $nome = $_POST["nome"];
        $cpf = $_POST["cpf"];
        $hierarquia = $_POST["hierarquia"];
        $telefone = $_POST["telefone"];
        $email = $_POST["email"];
        
        try{
            mysqli_query($con, "UPDATE cliente 
            SET nome='$nome', cpf='$cpf', hierarquia='$hierarquia', telefone='$telefone', email='$email' 
            WHERE id='$id'");
            echo("<p>Dados alterados com sucesso!!</p>");
            header("Location:../paginas/home.php");
        }catch(Exception $e){
            echo("Erro ao alterar dados no banco: ".$e);
        }
 ?>