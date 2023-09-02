package Ringue;

import javax.swing.JOptionPane;

public class Principal {
	
	public static void main(String[] args) {
		Lutador l1 = new Lutador();
		Lutador l2 = new Lutador();
		Luta lutas = new Luta();
		
		JOptionPane.showMessageDialog(null, "Informe os dados do lutador...");
		l1.LerTudo();
		JOptionPane.showMessageDialog(null, "Agora Informe os dados do outro lutador...");
		l2.LerTudo();
		
		lutas.lutar(l1, l2, 0);
	}
}
