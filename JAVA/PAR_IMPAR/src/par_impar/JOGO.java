/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package par_impar;

/**
 *
 * @author Intel i5
 */
public class JOGO {
    
    public String resultado;
        
    public void Resultado(int jogador, int maquina){        
        int soma = jogador + maquina;
        
        if((soma%2) == 0){
            resultado = "PAR";
        }else{
            resultado = "ÍMPAR";
        }
    }
    
}
