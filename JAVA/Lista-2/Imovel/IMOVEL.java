package Imovel;

public class IMOVEL {
	private String endereço;
	private double preco;
	
	public IMOVEL() {}
	public IMOVEL(double pre) {this.preco = pre;}
	public IMOVEL(String end, double pre) {this.endereço = end; this.preco = pre;}
	
	public String getEndereço() {
		return endereço;
	}
	public void setEndereço(String endereço) {
		this.endereço = endereço;
	}
	public  double getPreco() {
		return preco;
	}
	public void setPreco(double preco) {
		this.preco = preco;
	}
	

}
