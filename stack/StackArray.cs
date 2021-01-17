using System;

namespace stack
{
    class StackArray
    {
        public int[] array;
        int top;

        public StackArray(int size)
        {
            array = new int[size];
            top = -1;
        }
        private bool isFull => top >= array.Length - 1;


        private bool isEmpty => top == -1;


        public void push(int value)
        {
            if (isFull)
            {
                Console.WriteLine("Stack overflow");

            }
            else
            {
                top++;
                array[top] = value;
            }
        }
        public int pop()
        {
            int value = 0;
            if (isEmpty)
            {
                Console.WriteLine("Stack underflow");


            }
            else
            {
                value = array[top];
                array[top] = 0;
                top--;
            }
            return value;
        }
        public int peek()
        {
            if (isEmpty)
            {
                Console.WriteLine("Stack underflow");
                return top;

            }
            else
            {
                return top;
            }
        }
        public void display()
        {



            for (var i = top; i >= 0; i--)
            {
                Console.WriteLine(array[i]);

            }






        }
    }


}
