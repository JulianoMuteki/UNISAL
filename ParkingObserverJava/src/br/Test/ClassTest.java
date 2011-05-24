package br.Test;

import static org.junit.Assert.*;

import org.junit.Test;

import br.Observer.Carros;
import br.Observer.Estacionamento;
import br.Observer.EstacionamentoIguatemi;

public class ClassTest {

	@Test
	public void testEstacionamentoIguatemi() {
		 Estacionamento estIguatemi = new EstacionamentoIguatemi("Iguetemi Parking", 120);
         estIguatemi.Attach(new Carros("Carro1", 1));
         estIguatemi.Attach(new Carros("Carro2", 2));

         estIguatemi.setNumVagas(121);
         estIguatemi.setNumVagas(125);

         estIguatemi.MudarDeAndar("Carro1", 5);

         estIguatemi.setNumVagas(200);
	}

}
