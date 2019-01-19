using System;
using System.Collections.Generic;

namespace AlgorithmsDataStructures
{

	public class Node<T>
	{
		public T value;
		public Node<T> next, prev;

		public Node(T _value)
		{
			value = _value;
			next = null;
			prev = null;
		}
	}

	public class OrderedList<T>
	{
		public Node<T> head, tail;
		private bool _ascending;

		public OrderedList(bool asc)
		{
			head = null;
			tail = null;
			_ascending = asc;
		}

		public int Compare(T v1, T v2)
		{
			int result = 0;
			if (typeof(T) == typeof(String))
			{
			  result = string.Compare(v1 as string, v2 as string);
			}
			else
			{
			  var hash1 = v1.GetHashCode();
			  var hash2 = v2.GetHashCode();
			  if (hash1 == hash2) result = 0;
        else if (hash1 < hash2) result = -1;
			  else result = 1;
			}

			return result;
		}

	  private void AddInTail(Node<T> _item)
	  {
	    if (head == null)
	    {
	      head = _item;
	      head.next = null;
	      head.prev = null;
	    }
	    else
	    {
	      tail.next = _item;
	      _item.prev = tail;
	    }
	    tail = _item;
	  }

    public void Add(T value)
		{
		  if (head == null)
		    AddInTail(new Node<T>(value));
		  else
		  {
		    Node<T> node = head;
		    Node<T> newNode = new Node<T>(value);
		    bool addCondition = false;

		    while (node != null)
		    {
		      var compareResult = Compare(value, node.value);

          addCondition = (compareResult <= 0 && _ascending) || (compareResult >= 0 && !_ascending);

		      if (addCondition)
		      {
		        newNode.prev = node.prev;
		        newNode.next = node;
		        node.prev = newNode;
		        if (newNode.prev != null)
		          newNode.prev.next = newNode;
		        else
		          head = newNode;

            break;
          }

		      node = node.next;
		    }

		    if (node == null)
		    {
		      newNode.prev = tail;
		      tail.next = newNode;
		      tail = newNode;
		    }
		  }
    }

		public Node<T> Find(T val)
		{
		  Node<T> node = head;
		  while (node != null)
		  {
		    int compareResult = Compare(val, node.value);

        if (compareResult == 0) return node;

        if((compareResult < 0 && _ascending) || (compareResult > 0 && !_ascending))
          break;

		    node = node.next;
		  }
      return null;
		}

		public void Delete(T val)
		{
		  Node<T> node = head;

		  while (node != null)
		  {
		    int compareResult = Compare(val, node.value);

		    if (compareResult == 0)
		    {
		      if (node.prev != null)
		        node.prev.next = node.next;
		      else
		        head = node.next;

		      if (node.next != null)
		        node.next.prev = node.prev;
		      else
		        tail = node.prev;

          break;
		    }

		    if ((compareResult < 0 && _ascending) || (compareResult > 0 && !_ascending))
		      break;

		    node = node.next;
		  }
		}

    public void Clear(bool asc)
		{
			_ascending = asc;

		  Node<T> node = head;
		  head = null;
		  tail = null;
		  while (node != null)
		  {
		    Node<T> nextNode = node.next;
		    node = null;
		    node = nextNode;
		  }
    }

		public int Count()
		{
		  int count = 0;
		  var node = head;

		  if (node != null)
		  {
		    while (node != null)
		    {
		      count++;
		      node = node.next;
		    }
		  }

		  return count;
    }

		List<Node<T>> GetAll()
		{
			List<Node<T>> r = new List<Node<T>>();
			Node<T> node = head;
			while (node != null)
			{
				r.Add(node);
				node = node.next;
			}
			return r;
		}
	}

}