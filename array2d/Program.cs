using System;

namespace array2d
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an 2D Array 
            int [,]array=new int[2,3]{{1,2,3},{4,5,6}};
           //Access the Elements of an Array
           Console.WriteLine(array[0,0]);
           //Display array using for loop
        for (var i = 0; i < 2; i++)
        {
            for (var k = 0; k < 3; k++)
            {
                Console.WriteLine("element of index [{0},{1}] in array1 is {2}",i,k,array[i,k]);
            }
        }
        //Display array using foreach loop
        foreach (var item in array)
        {
            Console.WriteLine(item);
            
        }
        //user input array
        for (var i = 0; i < 2; i++)
        {
            for (var k = 0; k < 3; k++)
            {
                Console.WriteLine("Enter element of index [{0},{1}] :",i,k);
                array[i,k]=int.Parse(Console.ReadLine());

            }
        }
           

        }
    }
}
