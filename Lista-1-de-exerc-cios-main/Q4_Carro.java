package Lista1;

import javax.swing.JOptionPane;

public class Q4_Carro {
	
	private String modelo;
	private String cor;
	private int ano ;
	private String marca;
	private int velocidade;
	int validar;
	
	
	public String getModelo() {
		return modelo;
	}
	public void setModelo(String modelo) {	
		this.modelo = modelo = JOptionPane.showInputDialog("Informe o modelo do carro: ");
	}
	public String getCor() {
		return cor;
	}
	public void setCor(String cor) {
		this.cor = cor = JOptionPane.showInputDialog("Informe a cor do carro: ");
	}
	public int getAno() {
		return ano;
	}
	public void setAno(int ano) {
		this.ano = ano = Integer.parseInt(JOptionPane.showInputDialog("Informe o ano do carro: "));
	}
	public String getMarca() {
		return marca;
	}
	public void setMarca(String marca) {
		this.marca = marca = JOptionPane.showInputDialog("Informe a marca do carro: ");
	}
	public int getVelocidade() {
		return velocidade;
	}
	public void setVelocidade(int velocidade) {
		this.velocidade = velocidade;
	}
	
	
	
	public void acelerar () {
		this.validar = Integer.parseInt(JOptionPane.showInputDialog("Informe (1) para acelerar e (-1) para desacelera: "));
		 do{
			 	if(this.validar != 1 && this.validar != -1 ){
				
					JOptionPane.showMessageDialog(null, "Erro, informe (1) ou (-1)!!!");
					this.validar = Integer.parseInt(JOptionPane.showInputDialog("Informe (1) para acelerar e (-1) para desacelera: "));	 
			}
		if(this.validar == 1) {
			JOptionPane.showMessageDialog(null, "Velocidade aumentada em 5km/h!!");
			this.velocidade = this.velocidade + 5;
		} 
			if (this.validar == -1) {
			this.velocidade = this.velocidade - 5;
				if (this.velocidade < 0) {
					JOptionPane.showMessageDialog(null, "A velocidade já está em 0km/h, impossivel diminuir mais!!!");
					this.velocidade = 0;
				}else {
					JOptionPane.showMessageDialog(null, "Velocidade diminuida em 5km/h!!");
				}
			}
		}while(this.validar != 1 && this.validar != -1 );
	}
	
	
	
	public void frear() {
		
		this.validar = Integer.parseInt(JOptionPane.showInputDialog("Você realmente quer frear? (1) para sim e (-1) para não: "));
		 
		do{	 
			if(this.validar != 1 && this.validar != -1 ){
				JOptionPane.showMessageDialog(null, "Erro, informe (1) ou (-1)!!!");
				this.validar = Integer.parseInt(JOptionPane.showInputDialog("Você realmente quer frear? (1) para sim e (-1) para não: "));			 
			}
		 
			if(this.validar == 1) {
				JOptionPane.showMessageDialog(null, "O carro freou com sucesso!!!");
				this.velocidade = 0;
		} 
		
			if (this.validar == -1) {
				JOptionPane.showMessageDialog(null, "Tudo bem.");
			}
		
		 }while(this.validar != 1 && this.validar != -1 );
	}

	
	
		public static void main (String[]args) {
			Q4_Carro c1 = new Q4_Carro();
			
			c1.setModelo(null);
			c1.setMarca(null);
			c1.setCor(null);
			c1.setAno(0);
			c1.acelerar();
			c1.acelerar();
			c1.frear();
			JOptionPane.showMessageDialog(null, "Modelo: "+ c1.getModelo()+ "\nMarca: "+ c1.getMarca()+"\nCor: "+ c1.getCor()+"\nAno: "+ c1.getAno()+"\nVelocidade: "+ c1.getVelocidade()+"Km/h");
		
		}
	}

