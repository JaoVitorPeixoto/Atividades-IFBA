/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package par_impar;

import java.util.Random;


public class MAQUINA extends PLAYER{
        
    public MAQUINA(){
        Random gerador = new Random();
        numero = gerador.nextInt(51);
    }
    
    @Override
    public void Escolha(int e){
        if(e == 1){
            par_ou_impar = "PAR";
        }else{
            par_ou_impar = "ÍMPAR";
        }
    }
    
}
