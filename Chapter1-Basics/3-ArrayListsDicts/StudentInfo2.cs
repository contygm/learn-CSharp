 /****************************************************************************
 *
 *  PART 1
 *   1. prompt infinite loop 
 * 		- breaks user indicates the information is correct 
 * 	 2. print info after confirmation
 *
 *  PART 2
 *  prompts for additional students
 *     1. Easy 
 *			- user enters values again
 *			- print the information after confirmation
 *
 *     2. Recommended: 
 *			- store student information in a dict
 *        	- user confirms correct info 
 *			- add student to a list of students
 *			- When user says "no" to more students -> print student list
 *
 *        Hint: initialize your students list outside loop
 *
 *     3. Extra: accept either Y or y (lowercase) for "yes". 
 * 		 
 * 		  Hint: lower() method 
 *
 ***************************************************************************** */

using System.Collections.Generic;
using System;

class Program
{
	static void Main(string[] args)
	{
		// Master List
		List<string> pupils = new List<string>();
		
		while(true)
		{
			// Student info
			Dictionary<string, string> student = new Dictionary<string, string>();

			//gather info
			Console.WriteLine("Please enter your first name.");
			string firstName = System.Console.ReadLine();
			student.Add("First Name: ", firstName);

			Console.WriteLine("Please enter your middle name.");
			string middleName = System.Console.ReadLine();
			student.Add("Middle Name:", middleName);

			Console.WriteLine("Please enter your last name.");
			string lastName = System.Console.ReadLine();
			student.Add("Last Name: ", lastName);

			Console.WriteLine("Please enter your address.");
			string address = System.Console.ReadLine();
			student.Add("Address:", address);

			Console.WriteLine("Please enter your phone number.");
			string phone = System.Console.ReadLine();
			student.Add("Phone Number:", phone);

			Console.WriteLine("Please enter your email.");
			string email = System.Console.ReadLine();
			student.Add("Email: ", email);

			// confirm correct student info
			Console.WriteLine("Is the information correct? [Enter 'Y' for yes.]");
			var confirmation = System.Console.ReadLine();

			if (confirmation == "Y"){
				// show most recent addition
				foreach (KeyValuePair<string, string> entry in student)
			    {
			      Console.WriteLine("Added Student: ");
			      Console.WriteLine(entry.Key + " : " + entry.Value);
			      pupils.Add(entry.Value);
			    }

			    // prompt for adding another student
			    Console.WriteLine("Do you want to add another student? [Enter 'Y' for yes.]");
			    var addAnother = System.Console.ReadLine();
			    
			    // print master list when done adding
			    if (addAnother != "Y"){
					foreach (string pupil in pupils)
				    {
				        Console.WriteLine(pupil);
				    }
					break;
				}
			}		
		}
	}
}