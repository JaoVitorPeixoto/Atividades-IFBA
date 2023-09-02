<?php
    session_start();
    
    if(isset($_SESSION["hierarquiaCliente"])){ 
        
        $hierarquia = $_SESSION["hierarquiaCliente"]; 

        if($hierarquia == "ADM"){
            $validacao_hierarquia = true;
        }else if($hierarquia == "Cliente"){
            $validacao_hierarquia = false;
        }
    }else{
        $validacao_hierarquia = null;
    }

    
?>