package Imovel;

import java.util.Scanner;

public class Principal {

	public static void main(String[] args) {
		Scanner ler = new Scanner(System.in);
		
		int esco;
		
		System.out.println("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
		System.out.println("        IMOBILI�RIA PAGUE MENOS");
		System.out.println("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");//20
		System.out.println("===== Im�veis novos tem 5% de acr�scimo");
		System.out.println("===== Im�veis velhos tem 5% de desconto");
		System.out.println("----------------------------------------");
		System.out.println("Informe:\n[ 1 ] Para um im�vel novo\n[ 2 ] Para um im�vel velho");
		System.out.print("ESCOLHA: ");
		esco = ler.nextInt();
		
		while (esco < 1 || esco > 2) {
			System.out.println("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
			System.out.println("ERRO!! Informe corretamente:\n[ 1 ] Para um im�vel novo\n[ 2 ] Para um im�vel velho");
			System.out.print("ESCOLHA: ");
			esco = ler.nextInt();
		}
		System.out.println("----------------------------------------");
		
		if (esco == 1) {
			ImovelNovo i1 = new ImovelNovo();
			
			System.out.println("=============== IM�VEL NOVO ==============");	
			System.out.print("Informe o Endere�o do im�vel:");
			i1.setEndere�o(ler.next()); 
			System.out.print("Agora informe o pre�o do im�vel: R$");
			i1.setPreco(ler.nextDouble());
			System.out.println("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
			i1.setPreco_adicio();
			System.out.println("Como � um IM�VEL NOVO ele ter� 5% de acr�scimo, ent�o o valor total ser�: R$"+i1.getPreco_adicio()+" no endere�o [ "+i1.getEndere�o()+" ]");
		}else {
			ImovelVelho i1 = new ImovelVelho();
			
			System.out.println("=============== IM�VEL VELHO ==============");
			System.out.print("Informe o Endere�o do im�vel: ");
			i1.setEndere�o(ler.next());
			System.out.print("Agora informe o pre�o do im�vel: R$");
			i1.setPreco(ler.nextDouble());
			System.out.println("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
			i1.setPreco_desco();
			System.out.println("Como � um IM�VEL VELHO ele ter� 5% de desconto, ent�o o valor total ser�: R$"+i1.getPreco_desco()+" no endere�o [ "+i1.getEndere�o()+" ]");
		}
		System.out.println(">>>>>>>>>> FIM <<<<<<<<<<");
	}

}
