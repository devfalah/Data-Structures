namespace linkedList
{
   public class Node{
     int data;
      Node next;
    
    public Node(int data){
        Next=null;
        this.Data=data;
    }

        public int Data { get => data; set => data = value; }
        internal Node Next { get => next; set => next = value; }
    }
    }
