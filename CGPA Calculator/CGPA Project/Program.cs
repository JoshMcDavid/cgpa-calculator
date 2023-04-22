using System;
using System.Collections.Generic;
using System.Net;

namespace CGPACalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Greetings
            Console.WriteLine("\t\t\t Welcome To CGPA CALCULATOR\t\t\t\n");
            Console.Write("Welcome! Pls Enter your Full name: ");
            string fullName = Console.ReadLine();
            Console.WriteLine("Hello " + fullName);

            Console.WriteLine();
            Console.WriteLine();

            List<CourseData> Courselist = new List<CourseData>();

            Console.Write("Press '1' or '2' to enter new course: ");
            int response = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            int i = 0;
            while(response == 1)
            {
                CourseData courseData = new CourseData();


                Console.WriteLine("\t\t\t Welcome To CGPA CALCULATOR\t\t\t\n");
                Console.Write("Enter Course " + (i + 1) + ": ");
                courseData.course = Console.ReadLine();
                Console.Write("Enter the credit unit: ");
                courseData.unit = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Score: ");
                courseData.score = Convert.ToInt32(Console.ReadLine());
                Console.Write("Press '1' or '2' to enter new course: ");
                response = Convert.ToInt32(Console.ReadLine());
                Console.Clear();


                

                Courselist.Add(courseData);
                ++i;


                if (response != 1)
                {
                    
                    Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<<<<Report Sheet for "+ fullName + ">>>>>>>>>>>>>>>>>>>>>>>>>>>");
                    Console.WriteLine("|----------------|--------------|-------|------------|------------|----------------|");
                    Console.WriteLine("| COURSE & CODE  | COURSE UNIT  | GRADE | GRADE-UNIT | WEIGHT Pt. | REMARK         |");
                    Console.WriteLine("|----------------|--------------|-------|------------|------------|----------------|");
                    
                    
                }

              

            }
            int totalGradeUnit = 0;
            int totalWeightPoint = 0;
            int totalUnit = 0;
            int totalUnitPassed = 0;
            decimal cgpa = 0;
            foreach (CourseData courseData in Courselist)

            {

               

                if (courseData.score >= 70)

                {
                    courseData.grade = 'A';
                    courseData.gradeUnit = 5;
                    courseData.remarks = "Excellent";
                    courseData.weight = courseData.unit * courseData.gradeUnit;
                }
                else if (courseData.score >= 60 && courseData.score < 70)
                {
                    courseData.grade = 'B';
                    courseData.gradeUnit = 4;
                    courseData.remarks = "Very Good";
                    courseData.weight = courseData.unit * courseData.gradeUnit;
                }
                else if (courseData.score >= 50 && courseData.score < 60)
                {
                    courseData.grade = 'C';
                    courseData.gradeUnit = 3;
                    courseData.remarks = "Good";
                    courseData.weight = courseData.unit * courseData.gradeUnit;
                }
                else if (courseData.score >= 45 && courseData.score < 50)
                {
                    courseData.grade = 'D';
                    courseData.gradeUnit = 2;
                    courseData.remarks = "Fair";
                    courseData.weight = courseData.unit * courseData.gradeUnit;
                }
                else if (courseData.score >= 40 && courseData.score < 45)
                {
                    courseData.grade = 'E';
                    courseData.gradeUnit = 1;
                    courseData.remarks = "Pass";
                    courseData.weight = courseData.unit * courseData.gradeUnit;
                }
                else
                {
                    courseData.grade = 'F';
                    courseData.gradeUnit = 0;
                    courseData.remarks = "Fail";
                    courseData.weight = courseData.unit * courseData.gradeUnit;
                }
                

                Console.WriteLine("|{0,-16}|{1,-14}|{2,-7}|{3,-12}|{4,-12}|{5,-16}|", courseData.course, courseData.unit, courseData.grade, courseData.gradeUnit, courseData.weight, courseData.remarks);
                
                totalGradeUnit += courseData.gradeUnit;
                totalWeightPoint+= courseData.weight;
                totalUnit+= courseData.unit;
                cgpa = Convert.ToDecimal(totalWeightPoint) / Convert.ToDecimal(totalGradeUnit);
                cgpa = Math.Round(cgpa, 2);
                if (courseData.gradeUnit > 0)
                {
                    totalUnitPassed += courseData.unit;
                }
               

            };

            Console.WriteLine("|----------------|--------------|-------|------------|------------|----------------|");
            Console.WriteLine();
            Console.WriteLine("Total Course Unit Registered is " + totalUnit);
            Console.WriteLine("The total Course Unit Passed is " + totalUnitPassed);
            Console.WriteLine("The total Weight Point is " + totalWeightPoint);
            Console.WriteLine("Total grade unit is = " + totalGradeUnit);
            Console.WriteLine("Your GPA is = " + cgpa);

           

            Console.WriteLine();
        }


    }
}

