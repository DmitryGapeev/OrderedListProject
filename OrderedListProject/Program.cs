using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsDataStructures
{
	class Program
	{
		static void Main(string[] args)
		{

      TestAddSortedList(true);
      TestAddSortedList(false);

      Console.ReadKey();
		}

	  static void TestAddSortedList(bool asc)
	  {
	    Console.WriteLine("test ordered list asc = " + asc);
	    OrderedList<int> orderedList = new OrderedList<int>(asc);

	    Console.WriteLine("test add ");
      Console.WriteLine("head before add = " + (orderedList.head == null ? "null" : orderedList.head.value.ToString()));
	    Console.WriteLine("tail before add = " + (orderedList.tail == null ? "null" : orderedList.tail.value.ToString()));
      Console.WriteLine("size before add = " + orderedList.Count());

	    for (int i = 1, val = 1; i <= 15; i++, val += 10)
	    {
	      orderedList.Add(val);
	      Console.Write(val + " ");
	    }

      Console.WriteLine();
      ShowListElements(orderedList);
	    Console.WriteLine();
      ShowListElementsReverse(orderedList);
      Console.WriteLine("size after add = " + orderedList.Count());
	    Console.WriteLine("head after add = " + (orderedList.head == null ? "null" : orderedList.head.value.ToString()));
	    Console.WriteLine("tail after add = " + (orderedList.tail == null ? "null" : orderedList.tail.value.ToString()));


	    Console.WriteLine();
      Console.WriteLine("test delete 91");
	    Console.WriteLine("size before add = " + orderedList.Count());
      Console.WriteLine("head before add = " + (orderedList.head == null ? "null" : orderedList.head.value.ToString()));
	    Console.WriteLine("tail before add = " + (orderedList.tail == null ? "null" : orderedList.tail.value.ToString()));
      orderedList.Delete(91);
      ShowListElements(orderedList);
	    Console.WriteLine();
      ShowListElementsReverse(orderedList);
      Console.WriteLine();
	    Console.WriteLine("size after add = " + orderedList.Count());
	    Console.WriteLine("head after add = " + (orderedList.head == null ? "null" : orderedList.head.value.ToString()));
	    Console.WriteLine("tail after add = " + (orderedList.tail == null ? "null" : orderedList.tail.value.ToString()));

	    Console.WriteLine();
	    Console.WriteLine("test delete 1");
	    Console.WriteLine("size before add = " + orderedList.Count());
	    Console.WriteLine("head before add = " + (orderedList.head == null ? "null" : orderedList.head.value.ToString()));
	    Console.WriteLine("tail before add = " + (orderedList.tail == null ? "null" : orderedList.tail.value.ToString()));
	    orderedList.Delete(1);
	    ShowListElements(orderedList);
      Console.WriteLine();
	    ShowListElementsReverse(orderedList);
      Console.WriteLine();
	    Console.WriteLine("size after add = " + orderedList.Count());
	    Console.WriteLine("head after add = " + (orderedList.head == null ? "null" : orderedList.head.value.ToString()));
	    Console.WriteLine("tail after add = " + (orderedList.tail == null ? "null" : orderedList.tail.value.ToString()));

	    Console.WriteLine();
	    Console.WriteLine("test delete 141");
	    Console.WriteLine("size before add = " + orderedList.Count());
	    Console.WriteLine("head before add = " + (orderedList.head == null ? "null" : orderedList.head.value.ToString()));
	    Console.WriteLine("tail before add = " + (orderedList.tail == null ? "null" : orderedList.tail.value.ToString()));
	    orderedList.Delete(141);
	    ShowListElements(orderedList);
	    Console.WriteLine();
      ShowListElementsReverse(orderedList);
      Console.WriteLine();
	    Console.WriteLine("size after add = " + orderedList.Count());
	    Console.WriteLine("head after add = " + (orderedList.head == null ? "null" : orderedList.head.value.ToString()));
	    Console.WriteLine("tail after add = " + (orderedList.tail == null ? "null" : orderedList.tail.value.ToString()));

	    Console.WriteLine();
      Console.WriteLine("test find 71");
	    var result = orderedList.Find(71);
      Console.WriteLine(result.value);

	    Console.WriteLine();
	    Console.WriteLine("test find 131");
	    result = orderedList.Find(131);
	    Console.WriteLine(result.value);

	    Console.WriteLine();
	    Console.WriteLine("test find 11");
	    result = orderedList.Find(11);
	    Console.WriteLine(result.value);

	    Console.WriteLine();
	    Console.WriteLine("test find 1000");
	    result = orderedList.Find(1000);
	    Console.WriteLine(result == null ? "null" : result.value.ToString());

	    Console.WriteLine();
	    Console.WriteLine("test clear");
      orderedList.Clear(asc);
	    Console.WriteLine("size after add = " + orderedList.Count());
	    Console.WriteLine("head after add = " + (orderedList.head == null ? "null" : orderedList.head.value.ToString()));
	    Console.WriteLine("tail after add = " + (orderedList.tail == null ? "null" : orderedList.tail.value.ToString()));

      Console.WriteLine(new string('=', 50));
    }

	  static void ShowListElements<T>(OrderedList<T> list)
	  {
	    Node<T> node = list.head;
	    while (node != null)
	    {
	      Console.Write(node.value+" ");
	      node = node.next;
	    }
	  }

	  static void ShowListElementsReverse<T>(OrderedList<T> list)
	  {
	    Node<T> node = list.tail;
	    while (node != null)
	    {
	      Console.Write(node.value + " ");
	      node = node.prev;
	    }
    }

  }
}
