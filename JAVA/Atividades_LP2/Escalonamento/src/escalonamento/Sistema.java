/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package escalonamento;

public class Sistema {

	private double siste [][] = new double [3][4];
	private double x, y, z;
	

	public double[][] getSiste() {
		return siste;
	}

	public void setSiste(double[][] siste) {
		this.siste = siste;
	}
	

	public double getX() {
		return x;
	}

	public void setX(double x) {
		this.x = x;
	}

	public double getY() {
		return y;
	}

	public void setY(double y) {
		this.y = y;
	}

	public double getZ() {
		return z;
	}

	public void setZ(double z) {
		this.z = z;
	}
	
	public void ResolverSistema(double[][] sis){
		
		this.siste = sis;
		double[] l2 = new double [4];
		double[] l3 = new double [4];
		
		for(int i=0; i<4; i++) {
			l3[i] = this.siste[1][i] + this.siste[2][i] * -(this.siste[1][0] / this.siste[2][0]);
			l2[i] = this.siste[0][i] + this.siste[1][i] * -(this.siste[0][0] / this.siste[1][0]);
		}
		
		for(int i=0; i<4; i++) {
			this.siste[1][i] = l2[i];
			this.siste[2][i] = l3[i];
		}
		
		for(int i=0; i<4; i++) {
			l3[i] = this.siste[1][i] + this.siste[2][i] * -(this.siste[1][1] / this.siste[2][1]);
		}
		
		for(int i=0; i<4; i++) {
			this.siste[2][i] = l3[i];
		}
		
		setZ(this.siste[2][3] / this.siste[2][2]);
		setY( (this.siste[1][3] -(this.siste[1][2] * this.z)) / this.siste[1][1] );
		setX( (this.siste[0][3] -(this.siste[0][1] * this.y) -(this.siste[0][2] * this.z)) / this.siste[0][0] );
	}
	
	public static void main(String[]args) {
		Sistema sis = new Sistema();
		double[][] s = new double [3][4];
		
		s[0][0] = 1;
		s[0][1] = 2;
		s[0][2] = 1;
		s[0][3] = 12;
		s[1][0] = 1;
		s[1][1] = -3;
		s[1][2] = 5;
		s[1][3] = 1;
		s[2][0] = 2;
		s[2][1] = -1;
		s[2][2] = 3;
		s[2][3] = 10;
		sis.ResolverSistema(s);
		
		System.out.println(s[2][3]);
		System.out.println(sis.getX()+" "+sis.getY()+" "+sis.getZ());
	}
}
