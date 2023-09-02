package Imovel;

import java.util.Scanner;

public class Principal {

	public static void main(String[] args) {
		Scanner ler = new Scanner(System.in);
		
		int esco;
		
		System.out.println("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
		System.out.println("        IMOBILIÁRIA PAGUE MENOS");
		System.out.println("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");//20
		System.out.println("===== Imóveis novos tem 5% de acréscimo");
		System.out.println("===== Imóveis velhos tem 5% de desconto");
		System.out.println("----------------------------------------");
		System.out.println("Informe:\n[ 1 ] Para um imóvel novo\n[ 2 ] Para um imóvel velho");
		System.out.print("ESCOLHA: ");
		esco = ler.nextInt();
		
		while (esco < 1 || esco > 2) {
			System.out.println("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
			System.out.println("ERRO!! Informe corretamente:\n[ 1 ] Para um imóvel novo\n[ 2 ] Para um imóvel velho");
			System.out.print("ESCOLHA: ");
			esco = ler.nextInt();
		}
		System.out.println("----------------------------------------");
		
		if (esco == 1) {
			ImovelNovo i1 = new ImovelNovo();
			
			System.out.println("=============== IMÓVEL NOVO ==============");	
			System.out.print("Informe o Endereço do imóvel:");
			i1.setEndereço(ler.next()); 
			System.out.print("Agora informe o preço do imóvel: R$");
			i1.setPreco(ler.nextDouble());
			System.out.println("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
			i1.setPreco_adicio();
			System.out.println("Como é um IMÓVEL NOVO ele terá 5% de acréscimo, então o valor total será: R$"+i1.getPreco_adicio()+" no endereço [ "+i1.getEndereço()+" ]");
		}else {
			ImovelVelho i1 = new ImovelVelho();
			
			System.out.println("=============== IMÓVEL VELHO ==============");
			System.out.print("Informe o Endereço do imóvel: ");
			i1.setEndereço(ler.next());
			System.out.print("Agora informe o preço do imóvel: R$");
			i1.setPreco(ler.nextDouble());
			System.out.println("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
			i1.setPreco_desco();
			System.out.println("Como é um IMÓVEL VELHO ele terá 5% de desconto, então o valor total será: R$"+i1.getPreco_desco()+" no endereço [ "+i1.getEndereço()+" ]");
		}
		System.out.println(">>>>>>>>>> FIM <<<<<<<<<<");
	}

}
