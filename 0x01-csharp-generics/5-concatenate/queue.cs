using System;

   /// <summary>MAkes new class</summary>
   /// <typeparam name="T"></typeparam>
    class Queue<T> 
    {
      /// <summary>checks type</summary>
      /// <returns>typeof</returns>
      public Type CheckType()
      {
         return typeof(T);
      }
       
       /// <summary>sets up node</summary>
       public class Node
       {
        private T value = default(T);
        private Node next = null;

        public Node(T input)
        {
         value = input;
        }
       }


       public Node head;
       public Node tail;
       public int count;
       /// <summary>
       /// adds node to end
       /// </summary>
       /// <param name="value"></param>
       public void Enqueue(T value)
       {
         Node add@ = new Node();
         if (head == null)
         {
            head = add@;
         }
         else
         {
            var tail = head;
            while (tail.next != null)
            {
               tail = tail.next;
            }
            tail.next = add@;
         }
         count++;
       }
       /// <summary>
       /// counts nodes
       /// </summary>
       /// <returns>count</returns>
       public int Count()
       {
         return count;
       }
       /// <summary>
       /// removes head
       /// </summary>
       /// <param name="value"></param>
       public void Dequeue(T value)
       {
        if (head == null)
        {
            Console.Writeline("Queue is empty");
            return default(T);
        }
        else 
        {
           T value = head.value;
           Node.Remove(head);
           return value;
        }
       }
       /// <summary>
       /// gives head value
       /// </summary>
       /// <param name="value"></param>
       public void Peek(T value)
       {
        if (head == null)
        {
            Console.Writeline("Queue is empty");
            return default(T);
        }
        else 
        {
           T value = head.value;
           return value;
        }
       }
       /// <summary>
       /// prints queue
       /// </summary>
       /// <param name="value"></param>
       public void Print(T value)
       {
        if (head == null)
        {
            Console.Writeline("Queue is empty");
            return default(T);
        }
        else
        {
            T value = curent.value;
            val curent = head;
            while (curent.next != null)
            {
               Console.Writeline(curent.value);
               curent = curent.next;
            }
        }
       }
       /// <summary>
       /// finds strings and chars
       /// </summary>
       /// <returns></returns>
       public string Concatenate()
	{
		Node node;

		if (head == null)
		{
			Console.WriteLine("Queue is empty");
			return null;
		}
		if (!(typeof(string) == typeof(T) || typeof(char) == typeof(T)))
		{
			Console.WriteLine("Concatenate() is for a queue of Strings or Chars only.");
			return null;
		}
		string concat = "";
		node = this.head;
		while (node != null)
		{
			concat += node.value.ToString();
			if (typeof(string) == typeof(T) && node.next != null)
				concat += " ";
			node = node.next;
		}
		return concat;
	}
    }
