using System;

namespace linkedList
{
    public class SingleLinkedList
    {
        Node Head;
        Node Tail;
        int Length;



        public SingleLinkedList()
        {
            Head = Tail = null;
            Length = 0;
        }
        public bool isEmpty => Head == null;

        public void insertFirst(int item)
        {
            var newNode = new Node(item);
            if (isEmpty)
            {
                Head = Tail = newNode;
                newNode.Next = null;
            }
            else
            {
                newNode.Next = Head;
                Head = newNode;
            }




            Length++;

        }
        public void insertLast(int item)
        {
            var newNode = new Node(item);
            if (isEmpty)
            {
                Head = Tail = newNode;
                newNode.Next = null;
            }
            Tail.Next = newNode;
            newNode.Next = null;
            Tail = newNode;

            Length++;

        }
        public void insertAtPos(int pos, int item)
        {
            if (pos < 0 || pos > Length)
            {
                Console.WriteLine("Out of the range");
            }
            else
            {


                if (pos == 0)
                    insertFirst(item);
                else if (pos == Length)
                    insertLast(item);
                else
                {
                    var newNode = new Node(item);
                    Node curr = Head;
                    for (int i = 1; i < pos; i++)
                        curr = curr.Next;
                    newNode.Next = curr.Next;
                    curr.Next = newNode;

                }

            }
        }
        public int listSize => Length;

        public void display()
        {
            if (isEmpty)
                Console.WriteLine("Linked List is empty");
            else{
                var Curr=Head;
                while (Curr!=null)
                {
                    Console.WriteLine(Curr.Data);
                    Curr = Curr.Next;

                }
            }
        }
        public void removeFirst()
        {
            if (isEmpty)
            {
                Console.WriteLine("Can not remove element from empty list");
            }
            else if (Length == 1)
            {
                Head = Tail = null;
                Length--;
            }
            else
            {
                Head = Head.Next;
                Length--;
            }

        }
        public void removeLast()
        {
            if (isEmpty)
            {
                Console.WriteLine("Can not remove element from empty list");
            }
            else if (Length == 1)
            {
                Head = Tail = null;
                Length--;
            }
            else
            {
                var Curr = Head;
                for (int i = 2; i < Length ; i++)
                    Curr = Curr.Next;
                Curr.Next = null;
                Tail = Curr;
                Length--;
            }
        }
        public void remove(int element)
        {
            if (isEmpty)
            {
                Console.WriteLine("Can not remove element from empty list");
            }
            else if (element == Head.Data)
            {
                removeFirst();
            }
            else if (element == Tail.Data)
            {
                removeLast();
            }
            else
            {
                Node Curr = Head.Next, Prev = Head;
                while (Curr != null && Curr.Data != element)
                {
                    Prev = Curr;
                    Curr = Curr.Next;
                }
                if (Curr == null)
                {
                    Console.WriteLine("Not found");

                }
                else
                {
                    Prev.Next = Curr.Next;
                }


            }

        }
        public void removeFromPos(int pos)
        {
            if (pos < 0 || pos >= Length)
            {
                Console.WriteLine("Out of the range");

            }


            else
            {
                if (pos == 0)
                {
                    removeFirst();
                }
                else if (pos == Length - 1)
                {
                    removeLast();
                }
                else
                {
                    Node Curr = Head.Next, Prev = Head;
                    for (int i = 1; i < pos; i++)
                    {
                        Prev = Curr;
                        Curr = Curr.Next;
                    }
                    Prev.Next = Curr.Next;
                    Length--;
                }
            }
        }
        public void reverse(){
            Node Curr,NextCurr,Prev;
            Prev=null;
            Curr=Head;
            
            NextCurr=Curr.Next;
            while (NextCurr!=null)

            {
                
                NextCurr=Curr.Next;
                Curr.Next=Prev;
                Prev=Curr;
                Curr=NextCurr;
                
            }
            Head=Prev;
        }



    }
}
