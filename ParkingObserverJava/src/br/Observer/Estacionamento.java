package br.Observer;

import java.util.ArrayList;
import java.util.List;

public abstract class Estacionamento {

	public String Symbol;
	private int NumVagas;
	
	private List<Carros>_carros = new ArrayList<Carros>();
	
	public String getSymbol() {
		return Symbol;
	}
	public void setSymbol(String symbol) {
		Symbol = symbol;
	}
	
	public Estacionamento(String symbol, int numVagas)
	{
	this.Symbol= symbol;
	this.NumVagas = numVagas;
	}
	
	public int getNumVagas() {
		return NumVagas;
	}
	public void setNumVagas(int numVagas) {	
		if(NumVagas != numVagas)
		{
		NumVagas = numVagas;
		Notify();
		}
	}
	public void Attach(Carros carro)
	{
		_carros.add(carro);
	}
	public void Detach(Carros carro)
	{
		_carros.remove(carro);
	}
	public void MudarDeAndar(String nomeCarro, int novoAndar)
	{
		for (Carros car : _carros) {
			if(car.Nome == nomeCarro)
			{
				car.Andar = novoAndar;
			}
		}
	}

	public void Notify()
	{
	for (ICarros carro : _carros) {
		carro.Update(this);
	}
	
	}
}
