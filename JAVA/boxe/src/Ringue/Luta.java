package Ringue;

import javax.swing.JOptionPane;

public class Luta {
	private Lutador desafiado;
	private Lutador desafiante;
	private int dia;
	private int mes;
	private int ano;
	
	public void setData() {
		JOptionPane.showMessageDialog(null, "Informe a data da luta...");
		this.setAno();
		this.setMes(0);
		this.setDia(0);	
	}
	public int getAno(){
		return this.ano;
	}

	public int getMes(){
		return this.mes;
	}

	public int getDia(){
		return this.dia;
	}

	public void setAno(){
		this.ano = Integer.parseInt(JOptionPane.showInputDialog("Informe o ano da luta: "));
	}

	public void setMes(int m){
		m = Integer.parseInt(JOptionPane.showInputDialog("Informe o mês da luta: "));
		if(m > 0 && m <= 12){
			this.mes = m;

		}else{
			while(m < 0 || m > 12){
				m = Integer.parseInt(JOptionPane.showInputDialog("ERRRO!! Informe corretamente o mês da luta: "));
			}
			
			this.mes = m;
		}
	}

	public void setDia(int d){
		d = Integer.parseInt(JOptionPane.showInputDialog("Informe o dia da luta: "));
		if(this.mes == 1 || this.mes == 3 || this.mes == 5 || this.mes == 7 || this.mes == 8 || this.mes == 10 || this.mes == 12 ){
			while(d <= 0 || d > 31){
				d = Integer.parseInt(JOptionPane.showInputDialog("ERRO!! Informe corretamente o dia da luta: "));
			}
			
			this.dia = d;
			
		}else if(this.mes == 4 || this.mes == 6 || this.mes == 9 || this.mes == 11){
				while(d <= 0 || d > 30){
					d = Integer.parseInt(JOptionPane.showInputDialog("ERRO!! Informe corretamente o dia da luta: "));
				}	
			
				this.dia = d;
				
			}else{
				while(d <= 0 || d > 28){
					d = Integer.parseInt(JOptionPane.showInputDialog("ERRO!! Informe corretamente o dia da luta: "));
				}
		
				this.dia = d;
			}
		}
	
	public void getData() {
		JOptionPane.showMessageDialog(null, "A data da luta será: "+this.getDia() + "/"+this.getMes()+"/"+this.getAno());
	}
	
	
	public void lutar(Lutador l1, Lutador l2, int esc){
		esc = Integer.parseInt(JOptionPane.showInputDialog("Informe:\n[ 0 ] Para "+l1.getNome()+" como DESAFIANTE\n[ 1 ] Para "+l2.getNome()+" como DESAFIANTE"));
		while(esc != 1 && esc != 0) {
			esc = Integer.parseInt(JOptionPane.showInputDialog("ERRO!! Informe corretamente:\n[ 0 ] Para "+l1.getNome()+"como DESAFIANTE\n[ 1 ] Para "+l2.getNome()+" como DESAFIANTE"));
		}
		
		if (esc == 0){
			this.desafiante = l1;
			this.desafiado = l2;
			this.desafiante.Apresentacao();
			JOptionPane.showMessageDialog(null, "Desafiando...");
			this.desafiado.Apresentacao();
		}else {
			this.desafiante = l2;
			this.desafiado = l1;
			this.desafiante.Apresentacao();
			JOptionPane.showMessageDialog(null, "Desafiando...");
			this.desafiado.Apresentacao();
		}
		this.setData();
		
		JOptionPane.showMessageDialog(null, "DESAFIANTE:\nNOME: "+this.desafiante.getNome()+"\nNACIONALIDADE: "+this.desafiante.getNacionalidade()+"\n-=-=-=-=-=-=-=-= NA DATA: "+this.dia+"/"+this.mes+"/"+this.ano+" -=-=-=-=-=-=-=-=\nDESAFIADO:\nNOME: "+this.desafiado.getNome()+"\nNACIONALIDADE: "+this.desafiante.getNacionalidade());
		
		
		esc = Integer.parseInt(JOptionPane.showInputDialog("Informe:\n[ 0 ] Houve EMPATE\n[ 1 ] O DESAFIADO"+this.desafiado.getNome()+" ganhou\n[ 2 ] O DESAFIANTE "+this.desafiante.getNome()+" ganhou"));
		while(esc != 0 && esc != 1 && esc != 2) {
			esc = Integer.parseInt(JOptionPane.showInputDialog("ERRO!! Informe corretamente:\n[ 0 ] Houve EMPATE\n[ 1 ] O DESAFIADO "+this.desafiado.getNome()+" ganhou\n[ 2 ] O DESAFIANTE "+this.desafiante.getNome()+" ganhou"));
		} 
	
		if (esc == 0) {
			this.desafiado.Empatarluta();
			this.desafiante.Empatarluta();
		}
		
		if (esc == 1) {
			this.desafiado.Ganharluta();
			this.desafiante.Perderluta();
			JOptionPane.showMessageDialog(null, "O DESAFIADO "+this.desafiado.getNome()+" GANHOU A LUTA!!!");
			this.desafiado.Apresentacao();
		}
		
		if (esc == 2) {
			this.desafiante.Ganharluta();
			this.desafiado.Perderluta();
			JOptionPane.showMessageDialog(null, "O DESAFIANTE "+this.desafiante.getNome()+" GANHOU A LUTA!!!");
			this.desafiante.Apresentacao();
		}
	
	}
	
}
	
