﻿// declare two string variables
string firstName;
string lastName;

// prompt for first name using Write() to keep it on the same line
Console.Write("Enter First Name: ");
// use ReadLine() to get the name and assign its value to the variable
firstName = Console.ReadLine();

// same for last name... Write() and ReadLine()
Console.Write("Enter Last Name: ");
lastName = Console.ReadLine();

// Use WriteLine() to output message in the console
Console.WriteLine("Hello and Welcome " + firstName + " " + lastName + "," + " Nice to meet you! " + ".");
