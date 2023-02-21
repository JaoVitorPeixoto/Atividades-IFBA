/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package conexao;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import javax.swing.JOptionPane;
import java.sql.Date;
import java.util.ArrayList;
import java.util.List;

/**
 *
 * @author Intel i5
 */
public class Ranking_DAO {
    
        
    Connection con = null;
    PreparedStatement pstm = null;
    ResultSet rst = null;

    public void FecharConexao() {
            try {
                    if (con != null) {
                            con.close();
                    }

                    if (pstm != null) {
                            pstm.close();
                    }

                    if (rst != null) {
                            rst.close();
                    }

            }catch(Exception e) {
                    JOptionPane.showMessageDialog(null, "Não foi possível fechar a conexão com o banco de dados, Erro: "+ e);
            }
    }
    
    public void InserirRanking(Ranking r){
        
        String comando = " INSERT INTO ranking(nome, quantidade_vitoria, data) VALUES(?, ?, ?)";
        
        try{
            
            con = Conexao_mysql.conexaoBD();
            pstm = con.prepareStatement(comando);
            
            pstm.setString(1, r.nome);
            pstm.setInt(2, r.quantidade_vitoria);
            pstm.setDate(3, new Date(r.data.getTime()));
            
            pstm.execute();
            
        }catch(Exception e){
            JOptionPane.showMessageDialog(null, "Não foi possivel inserir um novo ranking, erro: "+ e);
        }finally{
            this.FecharConexao();
        }
        
    }
    
    public List<Ranking> MostrarRanking(){
        
        String comando = "SELECT * FROM ranking ORDER BY quantidade_vitoria DESC";
        List<Ranking> ranking = new ArrayList<>();
        
        try{
            
            con = Conexao_mysql.conexaoBD();
            pstm = con.prepareStatement(comando);
           
            rst = pstm.executeQuery();
            while (rst.next()){
                Ranking r = new Ranking();
                
                r.id = rst.getInt("id");
                r.nome = rst.getString("nome");
                r.quantidade_vitoria = rst.getInt("quantidade_vitoria");
                r.data = rst.getDate("data");
                
                ranking.add(r);
            }
                    
        }catch(Exception e){
            JOptionPane.showMessageDialog(null, "Não foi possivel mostrar o ranking, erro: "+ e);
        }finally{
            this.FecharConexao();
        }
        return ranking;
    }
    
    public void ApagarRanking(int id){
        
        String comando = "DELETE FROM ranking WHERE id = ?";
        
        try{
            
            con = Conexao_mysql.conexaoBD();
            pstm = con.prepareStatement(comando);
            
            pstm.setInt(1, id);
            
            pstm.execute();
            
        }catch(Exception e){
                        JOptionPane.showMessageDialog(null, "Não foi possivel deletar o ranking, erro: "+ e);

        }finally{
            this.FecharConexao();
        }
    }
}
