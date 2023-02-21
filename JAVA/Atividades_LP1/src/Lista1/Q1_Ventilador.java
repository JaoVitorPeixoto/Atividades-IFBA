package Lista1;


public class Q1_Ventilador {
		
		String cor;
		int qntlamina;
		String marca;
		int velocidade;
		boolean modo;
		
		public Q1_Ventilador (String marca, String cor, int qntlamina) {
			this.marca = marca;
			this.cor = cor;
			this.qntlamina = qntlamina;
			this.velocidade = 0;	
		}
		
		public String Aumentarvelo() {
			if(this.velocidade<3 && this.velocidade >=0) {
				this.velocidade = this.velocidade + 1;
				return"Velocidade aumentou em mais 1!!"; 				
			}else 
				return"Não é possível, velocidade máxima alcaçada!!";
				}
		public String Diminuirvelo() {
			if(this.velocidade<=3 && this.velocidade >0) {
				this.velocidade = this.velocidade - 1;
				return"Velocidade diminuio em 1!!"; 				
			}else {
				return"Não é possível, velocidade mínima alcaçada!!";
			}
		}		
		public String Empurrarpino() {
			if (!modo) {
				this.modo = true;
				return "Ventilador está girando...";		
			}else {
				return "Não é possível, o ventilador já está girando!!";
			}
		}	
		public String puxarpino() {
			if (modo) {
				this.modo = false;
				return "Ventilador está parado...";		
			}else {
				return "Não é possível, o ventilador já está parado!!";
			}
		}
		
@Override
		public String toString() {
			return "Q1_Ventilador [cor=" + cor + ", qntlamina=" + qntlamina + ", marca=" + marca + ", velocidade="
					+ velocidade + ", modo=" + modo + "]";
		}

	public static void main(String[]args) {
	
		Q1_Ventilador v1 = new Q1_Ventilador("Mondial", "Preto", 6);
		Q1_Ventilador v2 = new Q1_Ventilador("Arno", "Azul", 8);
	
		System.out.println(v1.Aumentarvelo());	
		System.out.println(v1.Aumentarvelo());
		System.out.println(v1.Diminuirvelo());
		System.out.println(v1.Empurrarpino());
		System.out.println(v1.puxarpino());
		
		System.out.println("______________________________________________");
		System.out.println(v2.Aumentarvelo());	
		System.out.println(v2.toString());
		System.out.println(v2.Aumentarvelo());
		System.out.println(v2.toString());
		System.out.println(v2.Diminuirvelo());
		System.out.println(v2.toString());
		System.out.println(v2.Empurrarpino());
		System.out.println(v2.toString());
		System.out.println(v2.puxarpino());
		System.out.println(v2.toString());
	}

}
