// Class

using System;
using System.Diagnostics.Metrics;

public class Metals // This is a class
{
	public string metal;
	public int stock;

		public Metals(string metal_name, int metal_quantity) // This is the stored embedded constructor that gives properties and values to the instances of its very class
		{
			metal = metal_name;
			stock = metal_quantity;
		}

		public override string ToString()
		{
			return $"The metal is: {metal}, the stock is_ {stock}";
		}
    static void Not_main(string[] args)
		{
			Metals iron = new Metals("iron", 5);
			Console.WriteLine(iron);
			Console.ReadLine();
		}

	}
/* JAVASCRIPT CLASS AND INSTANCE
 * class Metals {
 
	 *	constructor (metal_name, metal_quantity) {
	 *		this.metal_name = name;
	 *		this.metal_quantity = quantity
	 *	}
	 	
 * };
	* const iron = new Metals("iron", 3);
 * 
 */

public class Metal
{
	public string Metal_name { get; set; }
	public int Stock { get; set; }

	// ------

	public Metal(string name, int stock)
	{
		Metal_name = name;
		Stock = stock;
	}

	public override string ToString()
	{
		return $"Metal name: {Metal_name}, metal items: {Stock}";
	}

    static void Not_Main(string[] args)
	{
		Metal alluminium = new Metal("Alluminium", 10);
		Console.WriteLine($"{alluminium}");
		Console.Read();
	}
}
