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
         public Node add = new Node(value);
         if (head == null)
         {
            head = add;
         }
         else
         {
            tail.next = add;
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
    }
