using System;
//By adding using System; we can remove the System namespace tag from the methods in our code. This is called a using directive.
//This will reduce the amount of typing. (kinda ironic, especially when you look at all these comments right?)
//This should be fine so long as you don't use two methods with the same name that are in different namespaces.
//So System.Console.Write(); would be Console.Write(); and System.Console.ReadLine(); would be Console.ReadLine();
//They wouldn't clash because they both belong in the System namespace.

namespace MAAK1
{
  class Program
  {

    static void Main()
    {
      //== the int variable type allows you to store integers
      //== integers cannot be added to strings (in case you forgot)
      double runningTotal = 0;

      //== the bool variable type allows you to store one of two values true or false
      bool keepGoing = true;

      //== while is a type of loop in c# that allows the program to continue running until the argument is false
      while (keepGoing)
      {

        // ============= Prompt user for minutes exercised. =============
        //== All methods end with a ;
        Console.Write("Enter how many minutes you exercised or type 'quit' to exit: ");

        //== string is a variable type, entry is the variable name.
        //== string bookTitle; is a declared variable.
        //== string bookTitle = "The Raven"; is an initialised variable.
        //== Setting a variable equal to something is called vairable assignment.
        //== When you assign a variable at the same time as you declare it, it's called innitialising a variable.
        //== The System.Console.ReadLine(); method will read the string the user input in the console.
        //== string bookTitle = System.Console.ReadLine(); will read the input and save it in the bookTitle variable.
        //== The stirng returned from System.Console.ReadLine(); will be stored in this variable.
        string entry = Console.ReadLine();

        //== If statements are conditionals, if the argument/condition is met then the code inside will run.
        //== If the condition is not met, that part of the code is skipped and the program/app runs as usual.
        //== The else portion of this statement runs when the condition set above isn't met.
        //.ToLower() is a method used to convert uppercase input to lowercase
        if (entry.ToLower() == "quit" )
        {
          keepGoing = false;
        }
        else
        {
          try
          {
            //== int.Parse converts strings into integers
            //== double is a variable type that allows you to input numbers with decimals as opposed to int that only allows full numbers.
            double minutes = double.Parse(entry);

            if(minutes <= 0)
            {
              Console.WriteLine(minutes + " is not a acceptable value.");
              continue;
              //== continue statement tells the loop to continue running/returns to the beginning so the user can enter a new value.
            }
            else if(minutes <= 10)
            {
              Console.WriteLine("Better than nothing, am I right?");
            }
            else if (minutes <= 30)
            {
              Console.WriteLine("Look at you go!");
            }
            else if (minutes <= 60)
            {
              Console.WriteLine("You must be a Ninja Warrior in training or something!");
            }
            else
            {
              Console.WriteLine("Ugh, show off!");
            }
            //End if/else if/ else

            //  ============= Add minutes exercised to total  =============
            runningTotal = runningTotal + minutes;
            //  ============= Display total minutes exercised to screen  =============
            Console.WriteLine("You've entered "+ runningTotal +" minutes!");
            //== The WriteLine method prints something to the console, in this case a string including the string saved in the variable above.
          }
          catch(FormatException)
          {
            Console.WriteLine(" That is not a valid input.");
            continue;
          }

          //  ============= Repeat until user quits  =============

        }
        //End of ifelse
      }
      //End While Loop
      Console.WriteLine("Goodbye!");

    }
    //End Main method
  }
  //End Program class
}
//End namespace
