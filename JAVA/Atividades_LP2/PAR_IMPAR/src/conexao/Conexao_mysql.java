/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package conexao;

import java.sql.Connection;
import java.sql.DriverManager;


public class Conexao_mysql {
    
    private static final String USUARIO = "root";
		
    private static final String SENHA = "jvrfp15";
		
    private static final String URL_BANCO = "jdbc:mysql://localhost:3306/parimpar";
		
    public static Connection conexaoBD() throws Exception{
        
            Connection conexao = DriverManager.getConnection(URL_BANCO, USUARIO, SENHA);

            return conexao;
    }

}