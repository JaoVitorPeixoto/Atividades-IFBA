package Imovel;

public class IMOVEL {
	private String enderešo;
	private double preco;
	
	public IMOVEL() {}
	public IMOVEL(double pre) {this.preco = pre;}
	public IMOVEL(String end, double pre) {this.enderešo = end; this.preco = pre;}
	
	public String getEnderešo() {
		return enderešo;
	}
	public void setEnderešo(String enderešo) {
		this.enderešo = enderešo;
	}
	public  double getPreco() {
		return preco;
	}
	public void setPreco(double preco) {
		this.preco = preco;
	}
	

}
