using System;
using System.Collections.Generic;


    class Program
    {
        static void Main(string[] args)
        {
        //part 1
        Console.WriteLine("---First App---\nPlease type a word:");
        string string1 = Console.ReadLine();
        Console.WriteLine("Please type a word:");
        string string2 = Console.ReadLine();
        Console.WriteLine("Please type a word:");
        string string3 = Console.ReadLine();
        Console.WriteLine("Please type a word:");
        string string4 = Console.ReadLine();
        Console.WriteLine("Please type a word:");
        string string5 = Console.ReadLine();
        Console.WriteLine("Please type a word:\n");
        string string6 = Console.ReadLine();
        string[] words = { string1, string2, string3, string4, string5, string6 };
       foreach (string word in words)
        {
            Console.WriteLine(word);
        }
            

//part 2
        Console.WriteLine("\n---Second App---\nPlease type a number");
        string Number = Console.ReadLine();
        int i = Convert.ToInt32(Number);
        // I put original value value i greater than 0 the loop would ifinitly add one
        while (i<0)
        //solved by simply swapping  the greater than 0 for lesser than 0 which will end instantly unless negative value is typed in
        {
            i++;
            Console.Write("\t, "+i);
           
        }
//part 3        

        Console.WriteLine("\n---Third App---\nHow many points do you have on your driving license?");
       
        List<int> points = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
        foreach (int point in points)
         
        {
            if (point <= 11)
            {
                Console.WriteLine("you have "+point+" you can keep your license ");
            }
      

            else
            {
                Console.WriteLine("you have " + point + " or more points you have lost your license please retake driving and theory test");
            }
        }
        
        Console.ReadLine();

        Console.WriteLine("Welcome to store, before I sell you this product I need to see your ID");


        List<int> ages = new List<int> { 14, 16, 18, 25, 32 };

        foreach (int age in ages)


        {
            if (age < 18)
            {
                Console.WriteLine("You're " + age + " I'm sorry I can't sell you that");

            }
            else
            {
                Console.WriteLine("You're " + age + " Thank you for your purchase");
            }
            
        }
        Console.ReadLine();

        //part4

        List<string> cars = new List<string> { "Ford", "Honda", "Suzuki", "Seat", "Ferarri", "Lamborghini", "Toyota", "Vauxhall", "BMW", "Mercedes-Benz", "Fiat", "Honda" };



        Console.WriteLine("\n---Fourth App---\nSelect One of the following  Ford, Honda, Suzuki, Seat, Ferarri, Lamborghini, Toyota, Vauxhall, BMW, Mercedes - Benz, Fiat, Honda ");
        Console.WriteLine("Type one of the cars above (i.e type Ford)");
        string carMake = Console.ReadLine();
        foreach (string car in cars)

        {
            if (car == carMake)
            {
                Console.WriteLine("I have Found: " + car);
            }
            //I can't figure out how to make it to stop searching for values once correct value is put unless I remove the else but then I dont have the response when user puts data not on the list

           else
            {
                Console.WriteLine(carMake + " Doesnt match our records!");
            }
        }
        Console.ReadLine();


        //Ive done the different version of it but still same results

        //string[] cars = { "Ford", "Honda", "Suzuki", "Seat", "Ferarri", "Lamborghini", "Toyota", "Vauxhall", "BMW", "Mercedes-Benz", "Fiat", "Honda","Tesla" };

        //    Console.WriteLine("Select One of the following  Ford, Honda, Suzuki, Seat, Ferarri, Lamborghini, Toyota, Vauxhall, BMW, Mercedes - Benz, Fiat, Honda ");
        //Console.WriteLine("Type your car Model i.e Ford");
        //string carModel = Console.ReadLine();
        //for (int j = 0; j<cars.Length; j++)
        //{
        //    if (cars[j] == carModel)

        //    {
        //        Console.WriteLine(carModel+ " was found");
        //    }
        //    if (cars[j] != carModel)
        //    {
        //        Console.WriteLine(" Sorry "+carModel+" Was not found in the records");
        //    }
        //}
        //Console.ReadLine();





    }
}

