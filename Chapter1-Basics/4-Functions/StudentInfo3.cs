/* ****************************************************************************
 *   
 *     1. function that accepts string and Dictionary<string, string>
 *        - prompt the user for student attributes 
 *        - save the user's input to the dictionary
 *
 *     2. accept a Dictionary<string, string>
 *        - prints all of its key/value pairs.
 *
 *     3. prompt user as to whether the information they've entered is correct. 
 *        - return true if the user enters "Y" or "y", and false otherwise.
 *
 *     4. try moving methods to Helpers.cs file. 
 *        - put Helpers.cs in the correct namespace.
 *        - add the keyword "public" before the keyword "static" on each method in Helpers.cs
 *
 ***************************************************************************** */

using System;
using System.Collections.Generic;

namespace Students
{
  class Program
  {
    static void Main (String[] args)
    {

      List<Dictionary<string, string>> students = new List<Dictionary<string, string>>(); 

      while (true) {

        /* Next, create a dict, whose keys are the same as the variable names you've
         * been using. Set their value equal to "None", which is C#'s version of 
         * JavaScript's null. Refactor your calls to input such that they assign to
         * the dictionary's values directly, rather than to variable names. It'll
         * look very similar! */
        Dictionary<string, string> student = new Dictionary<string, string>();

        // Prompt for student attributes 
        Console.Write("Please enter the student's first name. ");
        string firstName = Console.ReadLine();
        student.Add("first name", firstName);

        Console.Write("Please enter the student's middle name. ");
        string middleName = Console.ReadLine();
        student.Add("middle name", middleName);

        Console.Write("Please enter the student's last name. ");
        string lastName = Console.ReadLine();
        student.Add("last name", lastName);

        // Prompt user for student"s contact information...
        Console.Write("Please enter the student's address. ");
        string address = Console.ReadLine();
        student.Add("address", address);

        Console.Write("Please enter the student's email. ");
        string email = Console.ReadLine();
        student.Add("email", email);

        Console.Write("Please enter the student's phone number. ");
        string phoneNumber = Console.ReadLine();
        student.Add("phone number", phoneNumber);

        // Print everything to the console...
        foreach (KeyValuePair<string, string> pair in student) {
          Console.WriteLine("The student's " + pair.Key + " is " + pair.Value + ".");
        }




        Console.Write("Is this information correct? (Y/n) ");
        string confirmation = Console.ReadLine();
        if (confirmation == "y" || confirmation == "Y")
          break;
      }
      
    }

  }
}