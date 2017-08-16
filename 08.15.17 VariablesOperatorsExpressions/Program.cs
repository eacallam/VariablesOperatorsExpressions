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
            int payment = 13;
            int people = 4;
            int totalBill = payment * people;
            Console.WriteLine(totalBill);
            //alternative
            Console.WriteLine(payment * people);
            Console.WriteLine(payment * 4);
            //Lisa is cooking muffins. The recipe calls for 7 cups of sugar. She has already put in 2 cups. How many more cups does she need to put in?
            int recipe = 7;
            int added = 2;
            int needed = recipe - added;
            Console.WriteLine(needed);
            //How many packages of diapers can you buy with $40 if one package costs $8?
            int cost = 8;
            int fund = 40;
            int diapers = 40 / 8;
            Console.WriteLine(diapers);
            //Last Friday Trevon had $29. Over the weekend he received some money for cleaning the attic. He now has $41. How much money did he receive?
            int initialBank = 29;
            int finalBank = 41;
            int received = 41 - 29;
            Console.WriteLine(received);
            Console.WriteLine("Trevon received" + " " + (finalBank - initialBank));
            ////Last week Julia ran 30 miles more than Pranav. Julia ran 47 miles. How many miles did Pranav run?
            int juliaMiles = 47;
            int previousMiles = 30;
            int pranavMiles = juliaMiles - previousMiles;
            Console.WriteLine(pranavMiles);
            ////How many boxes of envelopes can you buy with $12 if one box costs $3?
            int boxCost = 3;
            int bank = 12;
            int boxes = bank / boxCost;
            Console.WriteLine(boxes);
            ////After paying $5.12 for a salad, Norachai has $27.10. How much money did he have before buying the salad?
            double saladCost = 5.12d;
            double remaining = 27.10d;
            double startingBank = remaining + saladCost;
            Console.WriteLine(startingBank);
            ////331 students went on a field trip. Six buses were filled and 7 students traveled in cars. How many students were in each bus?
            int studentTotal = 331;
            int studentCars = 7;
            int studentBus = studentTotal - studentCars;
            int buses = 7;
            int busCapacity = studentBus / buses;
            Console.WriteLine(busCapacity);
            //Aliyah had $24 to spend on seven pencils.After buying them she had $10.How much did each pencil cost?
            float amountSpent = 24 - 10;
            float pencils = 7;
            float pencilCost = pencils / amountSpent;
            Console.WriteLine(pencilCost);
            //The sum of three consecutive numbers is 72.What are the smallest of these numbers?

            //The sum of three consecutive even numbers is 48.What are the smallest of these numbers?

            //Maria bought seven boxes. A week later half of all her boxes were destroyed in a fire. There are now only 22 boxes left. With how many did she start?
            int remainingBoxes = 22;
            int beforeFire = remainingBoxes * 2;
            int initial = beforeFire + 7;
            Console.WriteLine(initial);
        }
    }
}
