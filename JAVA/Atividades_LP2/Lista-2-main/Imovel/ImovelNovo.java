package Imovel;

public class ImovelNovo extends IMOVEL {
	private double preco_adicio;
	
	public ImovelNovo() { 
		
	}
	
	public ImovelNovo(String end, double pre) {
		
	}
	
	public ImovelNovo(String end, double pre, double preAdi) {
		super(end, pre);
		this.preco_adicio = preAdi;
	}	
	public ImovelNovo(double preAdi) {
		this.preco_adicio = preAdi;
	}
	
	public double getPreco_adicio() {
		return preco_adicio;
	}
	
	public void setPreco_adicio() {
		this.preco_adicio = this.getPreco() + (this.getPreco() * 5/100);
	}
	
	
	
}
