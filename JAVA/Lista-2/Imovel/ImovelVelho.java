package Imovel;

public class ImovelVelho extends IMOVEL {
	private double preco_desco;
	
	public ImovelVelho() { 
		
	}
	
	public ImovelVelho(String end, double pre) {
		
	}
	
	public ImovelVelho(String end, double pre, double preDesc) {
		super(end, pre);
		this.preco_desco = preDesc;
	}	
	public ImovelVelho(double preDesc) {
		this.preco_desco = preDesc;
	}
	
	public double getPreco_desco() {
		return preco_desco;
	}
	
	public void setPreco_desco() {
		this.preco_desco = this.getPreco() - (this.getPreco() * 5/100);
	}
	
}
	
	