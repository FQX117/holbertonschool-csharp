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

       public void Dequeue(T value)
       {
        if (head == null)
        {
            Console.write("Queue is empty");
            return default(T);
        }
        else 
        {
           T value = head.value;
           Node.Remove(head);
           return value;
        }
       }
    }
