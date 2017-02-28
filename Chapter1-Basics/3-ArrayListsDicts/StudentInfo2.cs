 /****************************************************************************
 *
 *  PART 1
 *   1. prompt infinite loop 
 * 		- breaks user indicates the information is correct 
 * 	 2. print info after confirmation
 *
 *  PART 2
 *  prompts for additional students
 *   
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
		Console.WriteLine("Please enter your first name.");
		string firstName = System.Console.ReadLine();

		Console.WriteLine("Please enter your middle initial.");
		string middleInitial = System.Console.ReadLine();

		Console.WriteLine("Please enter your last name.");
		string lastName = System.Console.ReadLine();

		Console.WriteLine("Please enter your address.");
		string address = System.Console.ReadLine();

		Console.WriteLine("Please enter your phone number.");
		string phone = System.Console.ReadLine();

		Console.WriteLine("Please enter your email.");
		string email = System.Console.ReadLine();

		Console.WriteLine("Your full name is "+ firstName +" "+ middleInitial +" "+ lastName + ".");
		Console.WriteLine("Your full name is "+ address +".");
		Console.WriteLine("Your full name is "+ phone +".");
		Console.WriteLine("Your full name is "+ email +".");

		Console.WriteLine("Is this information correct? [Enter 'Y' for yes and any other key for 'No'.");
		string confirmation = System.Console.ReadLine();
	}
	
}