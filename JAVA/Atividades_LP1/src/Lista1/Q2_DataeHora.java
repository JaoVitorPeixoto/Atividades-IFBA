package Lista1;

import javax.swing.JOptionPane;

public class Q2_DataeHora {

	private int hora;
	private int minuto;
	private int dia;
	private int mes;
	private int ano;
	
	public int getHora() {
		return hora;
	}
	
	
	
	public void setHora(int hora) {

		hora = Integer.parseInt(JOptionPane.showInputDialog("Informe a hora ente 24 e 1:"));
		if(hora <=24 && hora > 0) {
			this.hora = hora;
		}else {
			do {
				JOptionPane.showMessageDialog(null,"Erro, informe entre 24 e 1!!!");
				hora = Integer.parseInt(JOptionPane.showInputDialog("Informe a hora novamente:"));
			}while(hora <= 0 || hora > 24 );
		this.hora = hora;		
		}
		
		
		
	}
	public int getMinuto() {
		return minuto;
	}
	public void setMinuto(int minuto) {
		minuto = Integer.parseInt(JOptionPane.showInputDialog("Informe o minuto ente 60 e 0:"));
		if(minuto <=60 && minuto >=0) {		
			this.minuto = minuto;
		}else {
			do {
				JOptionPane.showMessageDialog(null,"Erro, informe entre 60 e 0!!!");
				minuto = Integer.parseInt(JOptionPane.showInputDialog("Informe o minuto novamente:"));
			}while(minuto < 0 || minuto > 60 );
		this.minuto = minuto;		
		}
	}
	
	
	
	public int getMes() {
		return mes;
	}
	
	
	
	public void setMes(int mes) {
		mes = Integer.parseInt(JOptionPane.showInputDialog("Informe o mês ente 12 e 1:"));
		if(mes <=12 && mes >=1) {		
			this.mes = mes;
		}else {
			do {
				JOptionPane.showMessageDialog(null,"Erro, informe entre 12 e 1!!!");
				mes = Integer.parseInt(JOptionPane.showInputDialog("Informe o mês novamente:"));
			}while(mes < 1 || mes > 12 );
		this.mes = mes;		
		}
		
	}
	
	public int getDia() {
		return dia;
	}
	public void setDia(int dia) {
		switch(this.mes) {
			case 1, 3 , 5, 7, 8, 10, 12:
					dia = Integer.parseInt(JOptionPane.showInputDialog("Informe o dia ente 31 e 1:"));
			if(dia < 1 || dia > 31) {
			do {
				JOptionPane.showMessageDialog(null,"Erro, informe entre 31 e 1!!!");
				dia = Integer.parseInt(JOptionPane.showInputDialog("Informe o dia novamente:"));
			}while(dia < 1 || dia > 31 );
			this.dia = dia;
		}	
			break;
			case 4, 6 , 9, 11:
				dia = Integer.parseInt(JOptionPane.showInputDialog("Informe o dia ente 30 e 1:"));
		if(dia < 1 || dia > 30) {
		do {
			JOptionPane.showMessageDialog(null,"Erro, informe entre 30 e 1!!!");
			dia = Integer.parseInt(JOptionPane.showInputDialog("Informe o dia novamente:"));
		}while(dia < 1 || dia > 30 );
		this.dia = dia;
	}	
		break;
			case 2:
				dia = Integer.parseInt(JOptionPane.showInputDialog("Informe o dia ente 28 e 1:"));
		if(dia < 1 || dia > 28) {
		do {
			JOptionPane.showMessageDialog(null,"Erro, informe entre 28 e 1!!!");
			dia = Integer.parseInt(JOptionPane.showInputDialog("Informe o dia novamente:"));
		}while(dia < 1 || dia > 28 );
		this.dia = dia;
	}	
		break;
		}
}
		
	
	
	public int getAno() {
		return ano;
	}
	public void setAno(int ano) {
		ano = Integer.parseInt(JOptionPane.showInputDialog("Informe o ano: "));
		this.ano = ano;
	}
	
	
	@Override
	public String toString() {
		return "DataeHora [hora=" + hora + ", minuto=" + minuto + ", dia=" + dia + ", mes=" + mes + ", ano=" + ano
				+ "]";
	}



	public static void main (String[]args) {
		Q2_DataeHora d1 = new Q2_DataeHora();
		
		d1.setHora(0);
		d1.setMinuto(0);
		d1.setMes(0);
		d1.setDia(0);
		d1.setAno(0);
		
		JOptionPane.showMessageDialog(null, "Hora: "+d1.getHora()+":"+d1.getMinuto()+"\nData: "+d1.getDia()+"/"+d1.getMes()+"/"+d1.getAno());
		System.out.println(d1.toString());
	}
	
}
