/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package par_impar;


public class JOGADOR1 extends PLAYER{
    
    public JOGADOR1(){
        
    }
    
    public JOGADOR1(int n){
        numero = n;
    }
    
        @Override
    public void Escolha(int e){
        if(e == 0){
            par_ou_impar = "PAR";
        }else{
            par_ou_impar = "ÌMPAR";
        }
    }
}
