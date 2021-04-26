using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //An Array is a collection of similar dataTypes..

            int[] evenNumbers = new int [3];
            evenNumbers[0] = 2;
            evenNumbers[1] = 4;
            evenNumbers[2] = 6;

            string[] student = new string [3];
            student[0] = "Andrey";
            student[1] = "Barak";
            student[2] = "Segun";

            Console.WriteLine(student[2]);
            Console.WriteLine();

            string [] studentsLists = {"Elijah","Ekene","Andrew","Sarah","Precious"};
            foreach(var studentName in studentsLists)
            {
                Console.WriteLine(studentName);
                Console.WriteLine();
            }
            //Console.WriteLine(studentsLists[3]);

            int [] evenNumber = {1,2,3,4,5};
            foreach(var Number in evenNumber)
            {
                Console.WriteLine(Number + 2);
                Console.WriteLine();
            }
            string [] studentsListsNames = {"Elijah","Ekene","Andrew","Sarah","Precious"};
            //string name = Array.FindAll;        

            for(int i= 0; i<studentsListsNames.Length; i+=2)
            {
                Console.WriteLine(studentsLists[i].ToLower());
              
            }

            int [,] multidimentionalArray = new int [4,4] 
            {
               {0,1,2,3}, //row = 0 
                {4,5,6,7}, //row = 1 
                {8,9,10,11}, //row = 2 
                {12,13,14,15} //row = 3 
            };

            for(int row = 0; row < 4; row++)
            {
                Console.WriteLine();
                Console.WriteLine($"This is row {row}");

                for(int column = 0; column < 4; column++)
                {
                    Console.WriteLine(multidimentionalArray[row,column]);
                }               
            }
        }
    }
}
