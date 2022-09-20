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
       
       public void Enqueue(T value)
       {
         Node add = new Node();
         if (head == null)
         {
            head = add;
         }
         else
         {
            var tail = head;
            while (tail.next != null)
            {
               tail = tail.next;
            }
            tail.next = add;
         }
         count++;
       }

       public int Count()
       {
         return count;
       }
    }
