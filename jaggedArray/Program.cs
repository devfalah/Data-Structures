using System;

namespace jaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
           //Create an jagged Array 
            var array=new int [3][];
            array[0]=new int[6]{0,0,0,0,0,0};
            array[1]=new int[5]{1,1,1,1,1};
            array[2]=new int[7]{2,2,2,2,2,2,2};

            for (var i = 0; i < 3; i++)
            {
                foreach (var item in array[i])
                {
                    Console.WriteLine(item);
                    
                    
                }
            }
        }
    }
}
