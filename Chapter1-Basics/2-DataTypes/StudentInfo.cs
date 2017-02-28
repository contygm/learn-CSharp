// Objectives
// 
// 	1. prompt the user for a student's 
//		- first name 
//  	- last name
// 		- middle initial 
//		- physical address
//		- email address 
//		- phone number
// 	2. print info to screen
// 	3. prompt the user to enter Y if the information is correct, or any other key otherwise
//	4. Save user response
// 

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
		Console.WriteLine("Your address is "+ address +".");
		Console.WriteLine("Your phone is "+ phone +".");
		Console.WriteLine("Your email is "+ email +".");

		Console.WriteLine("Is this information correct? [Enter 'Y' for yes and any other key for 'No'.");
		string confirmation = System.Console.ReadLine();
	}
	
}



