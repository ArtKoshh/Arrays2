using System;


namespace Arrays2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare 2d Array
            string[,] TwoD;


            //  Declare 3d Array
            string[,,] threeD;

            //two dimensional array
            int[,] array2d = new int[,]
            {
                {1, 2, 3}, // Row 0
                {4, 5, 6}, // row 1
                {7, 8, 9}, // row 2
            };
            Console.WriteLine("Central Value is {0}", array2d[1,1]);
            int[,] array2d2 = { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 6, 7 } };
            
            // three dimensional array
            string[,,] array3d = new string[,,]
            {
                {
                    {"000","001"},
                    {"010","011"}
                },
                {
                    {"100","101" },
                    {"110","111" }
                }
               
            };
            array3d[1, 1, 0] = "hello";
            Console.WriteLine("The Value is {0}", array3d[1,1,0]);












            /*
             // Arrays int/string
            string[] myFriends = { "Mike", "Ola", "Pelle", "Kalle", "Nisan" };

            foreach (string name in myFriends)
            {
                Console.WriteLine( "hi there {0}, My friend",name);    
            }
            */











            
            int[] nums = new int[10];
            
            for (int i = 0; i < 10; i++)
            {
                
                nums[i] = i + 10;
               
                Console.WriteLine("Element {0} = {1}", i, nums[i]);
            }

            
           /* for (int j = 0; j < 10; j++)
            {
                Console.WriteLine("Element {0} = {1}", j, nums[j]);
            }
            /*
             int counter =0;
             foreach (int k in nums)
             {
                 Console.WriteLine("Element {0} = {1}", counter++, nums[k]);
             }


             Console.ReadKey();
            /*
             string[] MyFriends = { "m", "a", "r" };
             foreach (var names in MyFriends)
             {
                 Console.WriteLine("Hello {0} my beloved friend",names);
             }
             */
        }
    }
}