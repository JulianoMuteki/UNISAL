package br.Observer;

public class Carros implements ICarros {
	
	public String Nome;
	public int Andar;
	
public int getAndar() {
		return Andar;
	}

	public void setAndar(int andar) {
		Andar = andar;
	}

public String getNome() {
		return Nome;
	}

	public void setNome(String nome) {
		Nome = nome;
	}

public Carros(String nome, int andar)
{
	this.Nome = nome;
	this.Andar = andar;
}

@Override
public void Update(Estacionamento estacionamento) {
   // Console.WriteLine(estacionamento.Symbol + " " + Nome + " está no andar " + Andar + " - " + "Vagas liberada em: QuadraX, CorredorY");
   // System.out.println(tv1.isLigado() ? "ligada" : "desligada");
}

}

