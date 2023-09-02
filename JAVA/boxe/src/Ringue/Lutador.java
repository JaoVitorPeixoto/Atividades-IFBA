package Ringue;

import javax.swing.JOptionPane;

public class Lutador {
	private String nome;
	private String nacionalidade;
	private double peso;
	private double altura;
	private int idade;
	private int vit;
	private int emp;
	private int der;
	
	
	public String getNome() {
		return nome;
	}
	public void setNome(String nome) {
		this.nome = nome;
	}
	public String getNacionalidade() {
		return nacionalidade;
	}
	public void setNacionalidade(String nacionalidade) {
		this.nacionalidade = nacionalidade;
	}
	public double getPeso() {
		return peso;
	}
	public void setPeso(double peso) {
		this.peso = peso;
	}
	public double getAltura() {
		return altura;
	}
	public void setAltura(double altura) {
		this.altura = altura;
	}
	public int getIdade() {
		return idade;
	}
	public void setIdade(int idade) {
		this.idade = idade;
	}
	public int getVit() {
		return vit;
	}
	public void setVit(int vit) {
		this.vit = vit;
	}
	public int getEmp() {
		return emp;
	}
	public void setEmp(int emp) {
		this.emp = emp;
	}
	public int getDer() {
		return der;
	}
	public void setDer(int der) {
		this.der = der;
	}
	
	public void LerTudo() {
		this.nome = JOptionPane.showInputDialog("Informe o NOME do lutador: ");
		this.nacionalidade = JOptionPane.showInputDialog("Informe a NACIONALIDADE do lutador: ");
		this.idade = Integer.parseInt(JOptionPane.showInputDialog("Informe a IDADE do lutador: "));
		this.altura = Double.parseDouble(JOptionPane.showInputDialog("Informe a ALTURA do lutador: "));
		this.peso = Double.parseDouble(JOptionPane.showInputDialog("Informe o PESO do lutador: "));
		this.vit = Integer.parseInt(JOptionPane.showInputDialog("Informe a quantidade de VITÓTRIAS do lutador: "));
		this.der = Integer.parseInt(JOptionPane.showInputDialog("Informe a quantidade de DERROTAS do lutador: "));
		this.emp = Integer.parseInt(JOptionPane.showInputDialog("Informe a quantidade de EMPATES do lutador: "));
		
	}
	
	public void Apresentacao() {
		JOptionPane.showMessageDialog(null, "NOME: "+ this.nome +"\nNACIONALIDADE: "+ this.nacionalidade +"\nIDADE: "+ this.idade +"\nALTURA: "+ this.altura +"\nPESO: "+ this.peso +"\nVITÓRIAS: "+ this.vit +"\nDERROTAS: "+ this.der +"\nEMPATES: "+ this.emp);
	}
	
	public void Ganharluta() {
		this.vit = this.vit + 1;
	}
	
	public void Perderluta() {
		this.der = this.der + 1;
	}
	
	public void Empatarluta() {
		this.emp = this.emp + 1;
	}
	
}
