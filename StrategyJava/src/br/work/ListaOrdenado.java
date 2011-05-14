package br.work;

import java.util.ArrayList;
import java.util.List;

public class ListaOrdenado {
	private  List<String> _list = new ArrayList<String>();
    private ISortStrategy _sortstrategy;
 
    public void SetSortStrategy(ISortStrategy sortstrategy)
    {
      this._sortstrategy = sortstrategy;
    }
 
    public void Add(String name)
    {
      _list.add(name);
    }
 
    public void Sort()
    {
      _sortstrategy.Sort(_list);
 
    
      for (String name : _list) {
    	  System.out.println(" " + name);
		
	}   
    }
}
