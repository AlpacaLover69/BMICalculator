using System;

namespace BMICalculator
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("BMI Calculator");

            Console.WriteLine("Enter your weight (kg):");
            double weight = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter your height (m):");
            double height = double.Parse(Console.ReadLine());

            double bmi = BMICalculator(weight, height);
            string bmiCategory = GetBMICategory(bmi);
            Console.WriteLine($"BMI Category: {bmiCategory}");

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }

        
        static double BMICalculator(double weight, double height)
        {
            // BMI Formula: weight / (height * height)
            return weight / (height * height);
        }

        
        static string GetBMICategory(double bmi)
        {
            if (bmi < 18.5)
                return "Underweight";
            else if (bmi >= 18.5 && bmi < 24.9)
                return "Normal weight";
            else if (bmi >= 24.9 && bmi < 29.9) 
                return "Overweight";
            else
                return "Obesity";
        }
    }
}
