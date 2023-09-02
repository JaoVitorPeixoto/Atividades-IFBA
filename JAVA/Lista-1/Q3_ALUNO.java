package Lista1;



import javax.swing.JOptionPane;

public class Q3_ALUNO {
	
	long matricula;
	String nome;
	double notap1;
	double notap2;
	double notatr;
	double media;
	boolean validacao;
	
	public void setDados () {
		this.nome = JOptionPane.showInputDialog("Informe o Nome: ");
		this.matricula = Long.parseLong(JOptionPane.showInputDialog("Informe a matrícula: "));
		}
	public String getNome() {
		return this.nome;
	}
	public long getmatricula() {
		return this.matricula;
	}
	
	public void adNotas () {
		this.notap1 = Double.parseDouble(JOptionPane.showInputDialog("Informe a nota da prova 1 (de 0-10): "));
		this.notap2 = Double.parseDouble(JOptionPane.showInputDialog("Informe a nota da prova 2 (de 0-10): "));
		this.notatr = Double.parseDouble(JOptionPane.showInputDialog("Informe a nota do trabalho (de 0-10): "));
		if (notap1 >= 0 && notap1<=10 && notap2 >=0 && notap2 <=10 && notatr >=0 && notatr <=10){
		 JOptionPane.showMessageDialog(null, "Tudo certo!!");
		}else {
		 do{
		 JOptionPane.showMessageDialog(null,"Erro!! Informe todas as notas novamente");
		 this.notap1 = Double.parseDouble(JOptionPane.showInputDialog("Informe a nota da prova 1: "));
		 this.notap2 = Double.parseDouble(JOptionPane.showInputDialog("Informe a nota da prova 2: "));
		 this.notatr = Double.parseDouble(JOptionPane.showInputDialog("Informe a nota do trabalho: "));
		 }while(notap1 < 0 || notap1 > 10 || notap2 < 0 || notap2 >10 || notatr < 0 || notatr >10);
		 JOptionPane.showMessageDialog(null, "Pronto, Tudo certo!!");
	     }
		
	
	}
	public double getNota1() {
		return this.notap1;
	}
	public double getNota2() {
		return this.notap2;
	}
	public double getNotatr() {
		return this.notatr;
	}
			
		 
	public double media() {
		this.media = (notap1*2.5 + notap2*2.5 + notatr*2)/7;
		return this.media;
	}

	public boolean validacao() {
		if (this.media >=6) {
			this.validacao = true;
			return this.validacao;
		}else {
			this.validacao = false;
			return this.validacao;
		}
	}
	
	
	public static void main (String [] args) {
	Q3_ALUNO a1 = new Q3_ALUNO();
	a1.setDados();
	a1.adNotas();
	
	JOptionPane.showMessageDialog(null,"Nome: " + a1.getNome() + "\nMatícula: "+ a1.getmatricula()+"\nNota prova 1 (Peso 2.5): "+a1.getNota1()+"\nNota prova 2 (Peso 2.5): "+ a1.getNota2()+"\nNota trabalho (Peso 2): "+ a1.getNotatr()+"\nMédia: "+a1.media()+"\nAprovação: "+a1.validacao());
}

}