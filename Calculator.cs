using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_prac
{
    class Calculator
    {        
        public void Addition()
        {
            int a = 4;
            int b = 5;
            int sum; 
            Console.WriteLine(sum = a + b);
        }
        public void Greatest()
        {   int num1;
            int num2;
            int num3;

            Console.WriteLine("Enter num1:");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter num2:");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter num3:");
            num3 = int.Parse(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("num1 is greatest");
            }
            else if (num2 > num3)
            {
                Console.WriteLine("num2 is greatest");

            }
            else Console.WriteLine("num3 is greatest");
        }
        

        public void percentage()
        {
            int Stu_Maths;
            int Stu_Eng;
            int Stu_Science;
           /* int Stu2_Maths;
            int Stu2_Eng;
            int Stu2_Science;
            int Stu3_Maths;
            int Stu3_Eng;
            int Stu3_Science;*/

            Console.WriteLine("Enter Stu_Maths:");
            Stu_Maths = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Stu_Eng:");
            Stu_Eng = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Stu_Science:");
            Stu_Science = int.Parse(Console.ReadLine());
            int Stu_Per = (Stu_Eng + Stu_Maths + Stu_Science) / 3;
            Console.WriteLine("Percentage of Student 1 :" + Stu_Per + "%");
            if (Stu_Per >= 75)
            {
                Console.WriteLine("Distinction");
            }
            else if(Stu_Per>=50 && Stu_Per<75)
            {
                Console.WriteLine("1st division");
            }
            else if (Stu_Per >= 35 && Stu_Per < 50)
            {
                Console.WriteLine("2nd division");
            }
            else
            {
                Console.WriteLine("Fail");
            }
        }
            /* Console.WriteLine("Enter Stu2_Maths:");
            Stu2_Maths = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Stu2_Eng:");
            Stu2_Eng = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Stu2_Science:");
            Stu2_Science = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Stu3_Maths:");
            Stu3_Maths = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Stu3_Eng:");
            Stu3_Eng = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Stu3_Science:");
            Stu3_Science = int.Parse(Console.ReadLine());

            int Stu1_Per = (Stu1_Eng + Stu1_Maths + Stu1_Science) / 3;
            Console.WriteLine("Percentage of Student 1 :" + Stu1_Per +"%");
            int Stu2_Per = (Stu2_Eng + Stu2_Maths + Stu2_Science) / 3;
            Console.WriteLine("Percentage of Student 2 :" + Stu2_Per+"%");
            int Stu3_Per = (Stu3_Eng + Stu3_Maths + Stu3_Science) / 3;
            Console.WriteLine("Percentage of Student 3 :" + Stu3_Per+"%");*/            
                                         
     static void Main(string[] args)
        {
            //int num = 30;
            //bool value = false;
            //char name= 'A';
            Calculator cal = new Calculator();
            //cal.Addition();
            //Console.WriteLine(Calculator.addition());
            //cal.Greatest();
            cal.percentage();

            for (int i = 0; i < 100; i++)
            {                
                Console.WriteLine("Do you want to enter 1 more student Yes/No");
                string Answer = Console.ReadLine();
                
                if (Answer == "Yes")
                {
                    cal.percentage();
                }
                else
                {
                    Console.WriteLine("No more student");
                    break;
                }
            }
            
           
            //Console.WriteLine("Hello" + num);
            //Console.WriteLine(value);
            //Console.WriteLine(name);
            Console.ReadKey();

        }
    }
}
