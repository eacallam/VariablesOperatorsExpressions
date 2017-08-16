using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08._15._17_VariablesOperatorsExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Elizabeth";
            Console.WriteLine(name);

            name = "Ashley";
            Console.WriteLine(name);
            // Case matters when naming variables. 
            string Name = "Elizabeth";
            //Below is an example of Camel Case.
            string birthMonth = "May";
            Console.WriteLine(birthMonth);
           
            //integers
            int birthMonthNumber = 12;
            int age = 65;
            int population = 10000;
           
            //floating-point types
            float number = 2.164403304897294383961032f;
            double someNumber = 2.164403304897294383961032d;
            decimal partialNumber = 2.164403304897294383961032m;

            Console.WriteLine(number);
            Console.WriteLine(someNumber);
            Console.WriteLine(partialNumber);

            //boolean type (true/false values)
            bool isPresent = true;
            Console.WriteLine(isPresent);

            //character type
            char lastLetter = 'j';
            Console.WriteLine(lastLetter);

            //OPERATORS: converting English to C#
            //Jessica is 23 years old.
            //Sam is 47.
            //Jessica is younger than Sam.
            int jessicaAge = 23;
            int samAge = 47;
            int total = samAge + jessicaAge;
            Console.WriteLine(jessicaAge < samAge);

            //At a restaurant, Mike and his three friends decided to divide the bill evenly. If each person paid $13 then what was the total bill?
            int bill = 13 * 4;
            Console.WriteLine(bill);

            //Lisa is cooking muffins. The recipe calls for 7 cups of sugar. She has already put in 2 cups. How many more cups does she need to put in?
            //How many packages of diapers can you buy with $40 if one package costs $8?
            //Last Friday Trevon had $29. Over the weekend he received some money for cleaning the attic. He now has $41. How much money did he receive?
            ////Last week Julia ran 30 miles more than Pranav. Julia ran 47 miles. How many miles did Pranav run?
            ////How many boxes of envelopes can you buy with $12 if one box costs $3?
            ////After paying $5.12 for a salad, Norachai has $27.10. How much money did he have before buying the salad?
            ////331 students went on a field trip. Six buses were filled and 7 students traveled in cars. How many students were in each bus?
            //Aliyah had $24 to spend on seven pencils.After buying them she had $10.How much did each pencil cost?
            //The sum of three consecutive numbers is 72.What are the smallest of these numbers?
            //The sum of three consecutive even numbers is 48.What are the smallest of these numbers?
            //Maria bought seven boxes. A week later half of all her boxes were destroyed in a fire. There are now only 22 boxes left. With how many did she start?

        }
    }
}
