using System;

namespace classAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Grades you got");
            string grade_number = Console.ReadLine();

                try
            {

                
                int value_of_grade = int.Parse("grade_number");
                if((value_of_grade>=0)&&(value_of_grade<=100))
                    {
                    var grade_in_char = Calculate_Grade(value_of_grade);
                    Console.WriteLine("Your Grade " + grade_in_char);
                }
                
                else
                {
                    Console.WriteLine("enter correct score");
                }
            }//edof try

            catch
            {
                Console.WriteLine("Error occured");
            }//edof catch

        }// edof main

        private static string Calculate_Grade(int std_grade)
        {

            if ((std_grade >= 95))
            {
                 
                return "A+";
            }//edof if >95
            else if( (std_grade >= 90) && (std_grade < 95))
            {
               
                return "A";
            }//edof if >90
           else  if ((std_grade >=87 ) && (std_grade < 90))
            {
                return "A-";
            }//edof if >87
            else if ((std_grade >= 84) && (std_grade < 87))
            {
                return "B+";
            }//edof if >84
            else if ((std_grade >= 80) && (std_grade < 84))
            {
                return "B";
            }//edof if >80
            else if ((std_grade >= 77) && (std_grade <80))
            {
                return "B-";
            }//edof if >77
            else if ((std_grade >= 74) && (std_grade < 77))
            {
                return "C+";
            }//edof if >74
            else if ((std_grade >= 70) &&(std_grade < 74))
            {
                return "C";
            }//edof if >70
            else if ((std_grade >=67 ) && (std_grade < 70))
            {
                return "C-";
            }//edof if >67
           else  if ((std_grade >= 63) && (std_grade < 67))
            {
                return "D+";
            }//edof if >63
            else if ((std_grade <= 60) && (std_grade < 63))
            {
                return "D";
            }//edof if <67
            else if (std_grade < 60)
            {
                return "F";
            }//edof if >67
            else
            {
                return "invalid";
            }
         
            
        }
    }
}