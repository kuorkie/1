using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1
{
	public class Sklad{
	    public int address{get;set;}
	    public int V{get;set;}
	    public string  otv{get;set;}
	    public int sklad{get;set;}
	    public int col{get;set;}
	    
	  public Sklad(int sklad, int col)
    {
      this.sklad= sklad;
      this.col = col;
      
    }
	}
	    public class Tovar:Sklad {
	    public string Name{get;set;}
	    public int Sku{get;set;}
	    public string opi{get;set;}
	    public int Cena{get;set;}
	    public string typi{get;set;}
	    
	    
	    public Tovar(string Name,int Sku,string opi,int Cena,string typi,int sklad,int col):base(sklad,col){
    this.Name = Name;//конструктор товардың
      this.Sku= Sku;
      this.opi= opi;
      this.Cena= Cena;
      this.typi= typi;
      this.sklad=sklad;
      this.col= col;
              
      }
       public void Print()
    {
      Console.WriteLine("The values of fields are:");
      Console.WriteLine($"{Name}");//принт деген метод жасадым
      Console.WriteLine($"{Sku}");
      Console.WriteLine($"{opi}");
      Console.WriteLine($"{Cena}");
      Console.WriteLine($"{typi}");
      Console.WriteLine($"{sklad}");
      Console.WriteLine($"{col}");
      
  }
  public void Dobav(){//добавление ну тип проверка склад 1 это открытый склад 
      if(base.sklad==1 && typi=="sypuchie"){
      Console.WriteLine("Peremestite na drugoi sklad");
      
          
      }
      else{
           base.col++;
           Console.WriteLine(col);
      }
  }

	    }
	    public class Person
	    {public string fio{get;set;}
	    public string dolzhnost{get;set;}
	            
	    }
	
	class Program
	{
		static void Main(string[] args)
		{
			Tovar t=new Tovar("cola",12,"kachestvo",450,"sypuchie",1,1);
            t.Print();
            t.Dobav();//я не знала как добавить в лист и как соединять при этом с методами соны карау керек я код у меня так себе я знаю))
		}
	}
 }
