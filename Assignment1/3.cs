using System;
using System.Collections;
class  Program {
	static public void Main()
	{
		ArrayList My_array = new ArrayList();
		My_array.Add('A');
		My_array.Add('b');
		My_array.Add('h');
		My_array.Add('i');
		My_array.Add('s');
		My_array.Add('h');
		My_array.Add('e');
		My_array.Add('k');
		My_array.Add('S');
		My_array.Add('h');
		My_array.Add('a');
		My_array.Add('r');
		My_array.Add('m');
		My_array.Add('a');
Console.WriteLine("Initial number of elements : "+ My_array.Count);
My_array.Remove('A');
		Console.WriteLine("After Remove() method the "+"number of elements: " + My_array.Count);
My_array.RemoveAt(8);
		Console.WriteLine("After RemoveAt() method the "+"number of elements: " + My_array.Count);
		My_array.RemoveRange(1, 3);
		Console.WriteLine("After RemoveRange() method the"+
		" number of elements: " + My_array.Count);
		My_array.Clear();
		Console.WriteLine("After Clear() method the "+
		"number of elements: " + My_array.Count);
		Console.WriteLine("created by Abhishek sharma");
		Console.WriteLine("MCA-II-A Roll-NO:06");
	}
}
