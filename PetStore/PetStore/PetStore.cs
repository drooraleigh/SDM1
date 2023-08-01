using System;

namespace PetStore
{
    public class PetStore
    {
        static void Main(string[] args)
        {
            ProductLogic logic = new ProductLogic();

            Console.WriteLine("Press 1 to add a product");
            Console.WriteLine("Type 'exit' to quit");
            string? userInput = Console.ReadLine();
            while (userInput.ToLower() != "exit")
            {
                if (userInput.ToLower() == "1")
                {
                    DogLeash leash = new DogLeash();

                    Console.Write("Enter name: ");
                    leash.Name = Console.ReadLine();

                    Console.Write("Enter price: ");
                    leash.Price = int.Parse (Console.ReadLine());

                    Console.Write("Enter quantity: ");
                    leash.Quantity = int.Parse (Console.ReadLine());

                    Console.Write("Enter description: ");
                    leash.Description = Console.ReadLine();

                    Console.Write("Enter material type: ");
                    leash.Material = Console.ReadLine();

                    Console.Write("Enter length in inches: ");
                    leash.lengthInches = int.Parse (Console.ReadLine());

                    logic.AddProduct(leash);
                    Console.WriteLine("New product has been added.");
                    //Console.WriteLine(String.Format("Name: {0}\nPrice: {1}\nQuantity: {2}\nDescription: {3}\nMaterial: {4}\nLength in inches: {5}", 
                    //leash.Name, leash.Price, leash.Quantity, leash.Description, leash.Material, leash.lengthInches));
                } else if (userInput.ToLower() == "2")
                {
                    Console.WriteLine("Name a product you would like to view.");
                    userInput = Console.ReadLine();
                    DogLeash leash = logic.GetDogLeashByName(userInput);

                    Console.WriteLine(String.Format("Name: {0}\nPrice: {1}\nQuantity: {2}\nDescription: {3}\nMaterial: {4}\nLength in inches: {5}",
                    leash.Name, leash.Price, leash.Quantity, leash.Description, leash.Material, leash.lengthInches));
                }
                Console.WriteLine("Press 1 to add a product");
                Console.WriteLine("Press 2 to view a product");
                Console.WriteLine("Type 'exit' to quit");
                userInput = Console.ReadLine();
            }
        }
    }
}  