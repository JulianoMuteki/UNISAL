package br.work;

import java.util.Collections;
import java.util.List;

public class QuickSort implements ISortStrategy {

	@Override
	public void Sort(List<String> list) {
		Collections.sort(list);// Default is Quicksort
  		 System.out.println("QuickSorted list");
		
	}

}
