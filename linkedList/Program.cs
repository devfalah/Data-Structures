using System;

namespace linkedList
{
    class Program
    {
        class Linked{
            Node head;
            public Linked(){
                head=null;
            }
            public void insert(int dd){
                Node  newNode=new Node(dd);
                newNode.Next=head;
                head=newNode;
            }
               public void display()
        {
            if (head==null)
                Console.WriteLine("Linked List is empty");
            else{
                var Curr=head;
                while (Curr!=null)
                {
                    Console.WriteLine(Curr.Data);
                    Curr = Curr.Next;

                }
            }
        }

        }
        static void Main(string[] args)
        {
            var list=new SingleLinkedList();
            var l=new Linked();
            l.insert(4);
            l.insert(4);
            l.insert(4);
            l.display();

            
            // list.insertLast(112);
            // list.insertLast(12);
            // list.insertLast(123);
            // list.insertLast(123);
            // list.removeLast();
         

            
            // list.display();
            
            
        }
    }

}
