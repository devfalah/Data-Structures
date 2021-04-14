namespace queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue q=new Queue(5);
           
            q.enqueue(1);
            q.enqueue(4);
            q.enqueue(5);
            q.enqueue(3);
            q.enqueue(2);
            q.dequeue();
            q.dequeue();
            
            q.display();
            
            
           
            
            
            
        }
    }
}
