package Imovel;

public class IMOVEL {
	private String endere�o;
	private double preco;
	
	public IMOVEL() {}
	public IMOVEL(double pre) {this.preco = pre;}
	public IMOVEL(String end, double pre) {this.endere�o = end; this.preco = pre;}
	
	public String getEndere�o() {
		return endere�o;
	}
	public void setEndere�o(String endere�o) {
		this.endere�o = endere�o;
	}
	public  double getPreco() {
		return preco;
	}
	public void setPreco(double preco) {
		this.preco = preco;
	}
	

}
