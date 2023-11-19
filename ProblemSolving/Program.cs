using System;

namespace ProblemSolving;
class Program
{
    static void Main()
    {
        #region problem 1 
        /*
        // 1. ask the user to insert a number then print it
        Console.WriteLine("Please enter a number:");
        int number = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine($"The number you entered is  : {number}");
        */
        #endregion

        //--------------------------------------------
        #region problem 2 
        /*
        //2. Check it the number is divided by 3 and 4
        Console.WriteLine("Please enter a number:");
        int num = Convert.ToInt16(Console.ReadLine());
        if(num % 3==0 && num % 4 == 0)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
        */
        #endregion

        //--------------------------------------------
        #region problem 3 
        /*
        //3. insert 2 numbers then print the max
        Console.WriteLine("Please enter a number:");
        int X = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Please enter a number:");
        int Y = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("The Max number is : "+Math.Max(X,Y));
        */
        #endregion
        //--------------------------------------------
        #region problem 4 
        /*
        //4. insert a number then print if positive or negative 
        Console.WriteLine("Please enter a number:");
        int S = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine((S>0)?"The number is Positive." : "The number is Negative.");
        */
        #endregion
        //--------------------------------------------
        #region problem 5
        /*
        //5. insert 3 number then print the max amd min element 
        Console.WriteLine("Please enter a 3 number:");
        int num1 = Convert.ToInt16(Console.ReadLine());
        int num2 = Convert.ToInt16(Console.ReadLine());
        int num3 = Convert.ToInt16(Console.ReadLine());
        int maxResult, minResult;
        //check max
        if(num1>num2 && num1 > num3)
        {
            maxResult = num1;
        }
        else if(num2>num1 && num2>num3)
        {
            maxResult = num2;
        }
        else
        {
            maxResult = num3;
        }
        //check min 
        if (num1 < num2 && num1 < num3)
        {
            minResult = num1;
        }
        else if (num2 < num1 && num2 < num3)
        {
            minResult = num2;
        }
        else
        {
            minResult = num3;
        }

        Console.WriteLine($"Max element is : {maxResult}\n" +
            $"Min element is : {minResult}");
        */
        #endregion
        //--------------------------------------------
        #region problem 6 
        /*
        //6. insert a number then check if it is odd or even
        Console.WriteLine("Please enter a number:");
        int j = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine((j%2==0)?"The number is even.":"The number is odd.");
        */
        #endregion
        //--------------------------------------------
        #region problem 7 
        /*
        //7. insert a char then check if it is voewl or consonant
        Console.WriteLine("Please enter a Character:");
        char  ch = Convert.ToChar(Console.ReadLine().ToLower());
        switch (ch)
        {
            case 'a':
                Console.WriteLine("Vowel");
                break;
            case 'e':
                Console.WriteLine("Vowel");
                break;
            case 'i':
                Console.WriteLine("Vowel");
                break;
            case 'o':
                Console.WriteLine("Vowel");
                break;
            case 'u':
                Console.WriteLine("Vowel");
                break;
            default:
                Console.WriteLine("Consonant");
                break;
        }
        */
        #endregion

        //--------------------------------------------
        #region problem 8
        /*
        //8. insert a number then print from 1 to the inserted number value
        Console.WriteLine("Please enter a number:");
        int k = Convert.ToInt16(Console.ReadLine());
        for(int b = 1; b <= k; b++)
        {
            Console.WriteLine(b);
        }
        */
        #endregion
        //--------------------------------------------
        #region problem 9
        /*
        //9. insert a number then print the multiplication of it
        int c;
        Console.WriteLine("Please enter a number:");
        int m = Convert.ToInt16(Console.ReadLine());
        for (int z = 1; z <= 12; z++)
        {
            c = m * z;
            Console.WriteLine(c);
        }
        */
        #endregion
        //--------------------------------------------
        #region problem 10
        //10. read a number and display the even numbers from 1 to that number
        /*Console.WriteLine("Please enter a number:");
        int q = Convert.ToInt16(Console.ReadLine());
        for(int t=1;t<=q; t++)
        {
            if (t % 2 == 0)
            {
                Console.Write($"{t} ,");

            }
        }*/
        #endregion
        //--------------------------------------------
        #region problem 11
        /*//11. read two numbers and print the power
        Console.WriteLine("Please inter 2 numbers :");
        int num1 = Convert.ToInt16(Console.ReadLine());
        int num2 = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine(Math.Pow(num1, num2));
        */
        #endregion
        //--------------------------------------------
        #region problem 12
        /* Console.WriteLine("Enter Markes of Five Subjects: ");
         int Sub1 = Convert.ToInt16(Console.ReadLine());
         int Sub2 = Convert.ToInt16(Console.ReadLine());
         int Sub3 = Convert.ToInt16(Console.ReadLine());
         int Sub4 = Convert.ToInt16(Console.ReadLine());
         int Sub5 = Convert.ToInt16(Console.ReadLine());
         int total = Sub1 + Sub2 + Sub3 + Sub4 + Sub5;
         int average = total / 5;
         int percentage = average * (100 / 100);
         Console.WriteLine($"Total markes = {total}");
         Console.WriteLine($"Average markes = {average}");
         Console.WriteLine($"Percentage markes = {percentage}");*/
        #endregion
        //--------------------------------------------
        #region problem 13
        /* // enter number of month and then print that month in words
         Console.WriteLine("Enter number of months and Year : ");
         int monthNum = Convert.ToInt16(Console.ReadLine());
         int year = Convert.ToInt16(Console.ReadLine());
         int days = DateTime.DaysInMonth(year, monthNum);
         Console.WriteLine(days);
         */
        #endregion
        //--------------------------------------------
        #region problem 14
        /*
        //program to get the grades
        Console.WriteLine("Enter Markes of Five Subjects: ");
        int physics = Convert.ToInt16(Console.ReadLine());
        int chemistry = Convert.ToInt16(Console.ReadLine());
        int biology = Convert.ToInt16(Console.ReadLine());
        int mathematics = Convert.ToInt16(Console.ReadLine());
        int computer = Convert.ToInt16(Console.ReadLine());
        int total = physics + chemistry + biology + mathematics + computer;
        int percentage = (total/5) * (100 / 100);
        if (percentage>=95)
        {
            Console.WriteLine("Your Grade is A ");
        }else if (percentage>=80)
        {
            Console.WriteLine("Your Grade is B ");

        }else if (percentage >= 70)
        {
            Console.WriteLine("Your Grade is c ");

        }else if (percentage >= 60)
        {
            Console.WriteLine("Your Grade is D ");

        }else if (percentage >= 40)
        {
            Console.WriteLine("Your Grade is E ");

        }else if (percentage < 40)
        {
            Console.WriteLine("Your Grade is F ");

        }
        else
        {
            Console.WriteLine("Please try again later.");

        }
        */

        #endregion
        //--------------------------------------------
        #region problem 15
        /*Console.WriteLine("Pease enter a number : ");
        int num1 = Convert.ToInt16(Console.ReadLine());
        if (num1 > 0)
        {
            Console.WriteLine("It's positive number");
        }
        else if (num1 <0)
        {
            Console.WriteLine("It's negative number");
        }
        else
        {
            Console.WriteLine("It's Zero");

        }*/
        #endregion
        //--------------------------------------------
        #region problem 17 
        // get string and print it on reverse order
        Console.WriteLine("Please enter a  string:");
        string s = Console.ReadLine();
        //Console.WriteLine(Revers(s));

        #endregion
    }
}

