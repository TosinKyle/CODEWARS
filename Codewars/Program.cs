using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using System.Net.Security;
using System.Numerics;

namespace Codewars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            double[] myArray = new double[] {1,5.2,4,0,-1,3};
            foreach (double i in myArray)
            {  
                sum = sum + i;
                Console.WriteLine(sum);
            }
            
            /* List<int> list = new List<int> { 1,2,3,4};
            list.Reverse();
            foreach (int i in list) { Console.WriteLine(i); }

            string myStringOfDigits = "123489764563";
            var number = Int64.Parse(myStringOfDigits);
            Console.WriteLine(number);
*/
        }
        public void ToDetermineMinAndMaxNumber() 
        {

            List<int> listOfNumbers = new List<int>()
            {
                70,45,87,23,09585,86584,12,1
            };
            listOfNumbers.Min();
            listOfNumbers.Max();
            Console.WriteLine(listOfNumbers.Max());
            Console.WriteLine(listOfNumbers.Min());
        }
        public void ToSumUpElemenstOfAnArrayExceptMinAndMax()
        {
            int[] myList = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int sum = 0;
            for (int i = 0; i < myList.Length; i++)
            {
                sum = sum + myList[i];
            }
            int newSum = 0;     //where shh=ould i initialize var
            newSum = sum - myList.Max() - myList.Min();
            Console.WriteLine(sum);
            Console.WriteLine(newSum);
        }
        public void ToSumUpElemenstOfAnArrayExceptMinAndMax3() 
        {
            int[] myList = { 20, 80, 30, 70, 50, 67 };
            int sum = 0;
            int newSum = 0;
            for (int i = 0; i < myList.Length; i++)
            {
                sum = sum + myList[i];
                Console.WriteLine(sum);
                newSum = sum - myList[0] - myList[3];
            }
            Console.WriteLine(newSum);
        }
        public void ToSumUpElemenstOfAnArrayExceptMinAndMax2()     //Not working
        {

            int[] myList = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int min = 0;
            int max = 0;
            int sum = 0;
            for (int i = 0; i <= myList.Length; i++)
            {
                if (myList[i] == myList.Min());
                {
                    min = i;
                }
                if (myList[i] == myList.Max());
                {
                    max = i;
                }
            }
            for (int i = 0; i < myList.Length; i++)
            {
                if (i != min & i != max)
                {
                    sum = sum + i;
                }

            }
            Console.WriteLine(sum);
        }
        public void ToCalculateInverse() 
        {
            int[] listOfNumbers = { 1, 2, 3, 4, 5, -8, -10, 6, -9 }; //Why did number<0 not work
            int inverse;
            foreach (int number in listOfNumbers)
            {
                bool isNumberPositive = number >= 0 ? true : false;

                if (number >= 0) //used= instead of == wh work
                {
                    inverse = 0 - number;
                    Console.WriteLine(inverse);
                }
                else
                {
                    inverse = 0 - (-number);
                    Console.WriteLine(inverse);
                }
            }
        }
        public void ToCalculateInverse2()
        {
            int[] listOfNumbers = { 1, 2, 3, 4, 5, -8, -10, 6, -9 }; //Why did number<0 not work
            int inverse;
            for (int i = 0; i < listOfNumbers.Length; i++)
            {
                inverse = -1 * listOfNumbers[i];
                Console.WriteLine(inverse);
            }
        }
        public void ToChnageValues() 
        {
            string myStringOfDigits = "12348976597345635999"; //Convert digits less than 5 to 0 and above  5 to 1
            string newString = ""; 
           long number = Int64.Parse(myStringOfDigits + 1);

           foreach (char i in myStringOfDigits)
           {
             
                newString += int.Parse(i.ToString()) < 5 ? "0" : "1";
               /* if (int.Parse( i.ToString()) < 5) 
                {
                   newString  = newString +'0';
                }
               if (i>'5')
               {
                   newString = newString + '1';
               }*/
           }
                 Console.WriteLine(newString);
        }
        public void ToCalculate()
        {
            int distanceToGetPump = 50;
            int milesPerGallon = 25;
            int fuelleft = 2;
            int result;
            result = milesPerGallon * fuelleft;
            if (result == distanceToGetPump)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
        public void ToFilterOutNoOfOccurences()
        {
            Console.WriteLine("Dear User, Kindly input a desired word"); //function that accepts a string and a single character,returns no of occurences.
            string input = Console.ReadLine();
            Console.WriteLine("Dear User, Kindly input a character that occurs in the word mentioned");
            char inputChar = char.Parse(Console.ReadLine());
            int result = 0;
            foreach (char c in input)
            {
                if (c == inputChar)
                {
                    result = result + 1;
                    ///Console.WriteLine(result);
                }
                else
                {
                    result = result + 0;
                    //Console.WriteLine(result);
                }
            }
            Console.WriteLine(result);
        }
        /*int[] arrayOfNumbers = { 1,2,3,4,5 };  //To sum up array of numbers
           int multiplication = 1;
           foreach (int number in arrayOfNumbers) 
           { 
            multiplication = multiplication * number;
            Console.WriteLine(multiplication);
           }
           Console.WriteLine(multiplication);*/
    }
    }
