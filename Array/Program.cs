using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
         // Create an 1D Array 
            int [] array1=new int[5]{1,2,3,4,5};
            int [] array2={1,2,3,4,5};
         //Access the Elements of an Array
            Console.WriteLine("element of index 0 is :{0}",array1[0]);
         //Array Length
        Console.WriteLine("array1 length is:{0}",array2.Length);
        //Display array using for loop
        for (var i = 0; i < array1.Length; i++)
        {
            Console.WriteLine("element of index {0} in array1 is {1}",i,array1[i]);
        }
        //Display array using foreach loop
        foreach (var item in array2)
        {
            Console.WriteLine(item);
            
        }
        //user input array
        for (var i = 0; i < array1.Length; i++)
        {
            Console.WriteLine("Enter element of index {0} :",i);
            array1[i]=int.Parse(Console.ReadLine());
        }
        

        }
    }
}
