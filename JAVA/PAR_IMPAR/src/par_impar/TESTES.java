/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package par_impar;

import conexao.Ranking;
import conexao.Ranking_DAO;
import java.util.ArrayList;
import java.sql.Date;
import java.util.List;

/**
 *
 * @author Intel i5
 */
public class TESTES {
    
    public static void main(String[]args){
    
        Ranking r = new Ranking();   
        Ranking_DAO dr = new Ranking_DAO();
        List<Ranking> ranking = new ArrayList<>();        
        
        
        ranking = dr.MostrarRanking();
        
        for(Ranking rks: ranking){
            System.out.println(rks.nome);
        }
        
     
    }
}
