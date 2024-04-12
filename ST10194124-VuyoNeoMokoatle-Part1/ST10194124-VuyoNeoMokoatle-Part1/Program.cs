using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10194124_VuyoNeoMokoatle_Part1
{
    class Programs
    {
        static void Main(string[] args)
        {
            // Instantiate a Recipe object
            RRecipes recipe = new RRecipes();

            // our main loop of the program
            while (true)
            {
                // this is to display menu options
                Console.WriteLine("Press '1' For recipe information");

                Console.WriteLine("Press '2' To show recipe");

                Console.WriteLine("Press '3' To scale recipe");

                Console.WriteLine("Press '4' Reset quantities");

                Console.WriteLine("Press '5' Clear recipe");

                Console.WriteLine("Press '6' Exit");

                // Read user choice
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        // Enter recipe details
                        recipe.EnterDetails();
                        break;
                    case "2":
                        // Show the recipe
                        recipe.DisplayRecipe();
                        break;
                    case "3":
                        // Scaling of the recipe
                        Console.Write("Enter scaling factor (0.5, 2, or 3): ");
                        double factor = double.Parse(Console.ReadLine());
                        recipe.ScaleRecipe(factor);
                        break;
                    case "4":
                        // Reset quantities
                        recipe.ResetQuantities();
                        break;
                    case "5":
                        // Clear the recipe
                        recipe.ClearRecipe();
                        break;
                    case "6":
                        // When you have Exit the program
                        Console.WriteLine("You now have exit the program...");
                        return;
                    default:
                        // Empty choice
                        Console.WriteLine("Empty choice. Please enter a valid choice that are numbered.");
                        break;
                }
            }
        }
    }
    internal class RRecipes
    {

        // This are my private fields
        private string[] Ingredts;

        private string[] Mysteps;

        private string[] Units;

        private double[] Quanties;



        public RRecipes()
        {

            Ingredts = new string[0];

            Mysteps = new string[0];

            Units = new string[0];

            Quanties = new double[0];

        }

        // Method to enter recipe details
        public void EnterDetails()
        {
            // Prompt the user to enter the number of ingredients
            Console.Write("Enter the number of ingredients: ");
            int numIngredients = int.Parse(Console.ReadLine());


            Ingredts = new string[numIngredients];
            Units = new string[numIngredients];
            Quanties = new double[numIngredients];

            // Prompt the user to enter the details for each ingredient
            for (int m = 0; m < numIngredients; m++)
            {
                Console.WriteLine($"Enter the information for your ingredient :{m + 1}:");
                Console.Write("Name: ");
                Ingredts[m] = Console.ReadLine();
                Console.Write("The unit of measurement: ");
                Units[m] = Console.ReadLine();
                Console.Write("Quantity: ");
                Quanties[m] = double.Parse(Console.ReadLine());
            }

            // Prompt the user to enter the number of steps
            Console.Write("Enter the number of steps: ");
            int numberSteps = int.Parse(Console.ReadLine());


            Mysteps = new string[numberSteps];

            // Prompt the user to enter the details for each step
            for (int v = 0; v < numberSteps; v++)
            {
                Console.Write($"Fill in the steps #{v + 1}: ");
                Mysteps[v] = Console.ReadLine();
            }
        }

        // Method to display the recipe
        public void DisplayRecipe()
        {
            // Display the ingredients and quantities
            Console.WriteLine("Ingredients:");
            for (int n = 0; n < Ingredts.Length; n++)
            {
                Console.WriteLine($"  - {Quanties[n]} {Units[n]} of {Ingredts[n]}");
            }

            // Display the steps
            Console.WriteLine("Steps:");
            for (int u = 0; u < Mysteps.Length; u++)
            {
                Console.WriteLine($"- {Mysteps[u]}");
            }
        }

        // Method to scale the recipe
        public void ScaleRecipe(double factor)
        {
            // Multiply all the quantities by the scaling factor
            for (int e = 0; e < Quanties.Length; e++)
            {
                Quanties[e] *= factor;
            }
        }

        // reset quantities to half
        public void ResetQuantities()
        {
            // Reset all the quantities to their original values
            for (int o = 0; o < Quanties.Length; o++)
            {
                Quanties[o] /= 2;
            }
        }

        // Method to clear the recipe
        public void ClearRecipe()
        {
            // Reset all the arrays to empty
            Ingredts = new string[0];

            Mysteps = new string[0];

            Units = new string[0];

            Quanties = new double[0];


        }
    }

}
