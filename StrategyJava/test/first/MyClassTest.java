package first;

//import static org.junit.Assert.*;

import org.junit.Test;

import br.work.ListaOrdenado;
import br.work.MergeSort;
import br.work.QuickSort;
import br.work.ShellSort;

public class MyClassTest {

	@Test
	public void testMatch() {
		ListaOrdenado estudante = new ListaOrdenado();
		
		estudante.Add("Samuel");
		estudante.Add("Jimmy");
		estudante.Add("Sandra");
		estudante.Add("Ana");
		estudante.Add("Victor");
		
		estudante.SetSortStrategy(new QuickSort());
		estudante.Sort();
		
		estudante.SetSortStrategy(new MergeSort());
		estudante.Sort();
		
		estudante.SetSortStrategy(new ShellSort());
		estudante.Sort();
	}



}
