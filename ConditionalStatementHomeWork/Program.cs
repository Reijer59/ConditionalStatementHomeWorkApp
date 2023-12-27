// Source Code
// Section Homework
// Conditional Statements If Construction

using System.Net.Security;

Console.WriteLine("\t\t Welcome to the Conditional Statement HomeWork assignment.");
Console.WriteLine("\t Please be so kind to review this app and leave your comments for improvement. ");
Console.WriteLine("\t -----------------------------------------------------------------------------");
Console.WriteLine("\t For this assignment I ask the User for their name. Welcome me (TIM),");
Console.WriteLine("\t as professor or anyone else as student. Make shure that Tim also ");
Console.WriteLine("\t gets called professor. Extra points are there to also call Timothy as professor.");
Console.WriteLine();

// 1. Create Variables
string? firstName;

// 2. Ask the User for Input
Console.Write("\t Can you please tell your first name: ");
firstName = Console.ReadLine();

// Insert blank line.
Console.WriteLine();

// 3. Create the if statement
if ((firstName == "TIM") || (firstName == "Tim") || (firstName == "Timothy"))
{
    Console.WriteLine($"\t Welcome professor {firstName}."); // Welcome only when firstName = TIM or Timothy.
}
else
{
    Console.WriteLine($"\t Hello and welcome student {firstName}."); // Welcome all other names as student.
}
Console.WriteLine();
Console.WriteLine("\t Press a Button to close the Application. ");
Console.ReadLine();
