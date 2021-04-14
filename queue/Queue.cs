using System;

namespace queue
{
    class Queue
    {
        private int []array;
        private int front ,rear;
        public Queue(int size)
        {
            front=0;
            rear=-1;
            array =new int[size];
        }
        public bool isEmpty(){
            return  front>rear;
        }
        public bool isFull(){
            return rear >=array.Length-1;
        }
        public void enqueue(int element){
            
            if(isFull()){ Console.WriteLine("Queue overflow"); }
            else{ array[++rear]=element; }
        }
        public int dequeue(){
            int value=0;
            if(isEmpty()){ Console.WriteLine("Queue underflow"); }
            else{
                value=array[front];
                
                front++;

            }
            return value;
        }
        public void display(){
            for (var i = front; i < rear+1; i++)
            {
                Console.WriteLine($"{array[i]}");
                
            }
        }
    }
}
