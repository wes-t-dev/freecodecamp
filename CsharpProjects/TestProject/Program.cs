// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, C#!");


//string value1 = " a";
//string value2 = "A ";
//Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());

//Console.WriteLine("a" != "a");
//Console.WriteLine("a" != "A");
//Console.WriteLine(1 != 2);
//
//string myValue = "a";
//Console.WriteLine(myValue != "a");


//******Coin Flip**********
//using System;
//
//Random coin = new Random();
//
//Console.WriteLine(coin.Next(0, 2) == 0 ? "heads" : "tails");
//**************************

//using System.Diagnostics;
//using System.Linq.Expressions;
//
//string permission = "|M";
//int level = 6;
//
//string message = "";
//if(permission.Contains("Admin"))
//{
//    message = level > 55 ? "Welcome, Super Admin user." : "Welcome, Admin user.";
//}
//else if(permission.Contains("Manager"))
//{
//    message = level >= 20 ? "Contact an Admin for access." : "You do not have sufficient privileges.";
//}
//else
//    message = "You do not have sufficient privileges.";
//
//Console.WriteLine(message);

//Variable Scope
//int[] numbers = { 4, 8, 15, 16, 23, 42 };
//bool found = false;
//int total = 0;
//foreach (int number in numbers)
//{
//    total += number;
//    if (number == 42) 
//        found = true;
//}
//
//if (found)
//    Console.WriteLine("Set contains 42");
//
//Console.WriteLine($"Total: {total}");

//Switch-Case
// SKU = Stock Keeping Unit. 
// SKU value format: <product #>-<2-letter color code>-<size code>
// string sku = "01-MN-L";

// string[] product = sku.Split('-');

// string type = "";
// string color = "";
// string size = "";


// switch (product[0])
// {
//     case "01":
//          type = "Sweat shirt";
//          break;
//     case "02":
//          type = "T-Shirt";
//          break;
//     case "03":
//          type = "Sweat pants";
//          break;
//     default:
//          type = "Other";
//          break;
// }
// switch (product[1])
// {
//     case "BL":
//          color = "Black";
//          break;
//     case "MN":
//          color = "Maroon";
//          break;
//     default:
//          color = "White";
//          break;
// }
// switch (product[2])
// {
//         case "S":
//          size = "Small";
//          break;
//     case "M":
//          size = "Medium";
//          break;
//     case "L":
//          size = "Large";
//          break;
//     default:
//          size = "One Size Fits All";
//          break;
// }

// Console.WriteLine($"Product: {size} {color} {type}");

//for loop
//for(int count = 1; count < 101; count++)
// {
//     if(count%3 == 0 && count%5 ==0)
//         Console.WriteLine($"{count} - FizzBuzz");
//     else if(count%3 == 0)
//         Console.WriteLine($"{count} - Fizz");
//     else if(count%5 == 0)
//         Console.WriteLine($"{count} - Buzz");
//     else
//         Console.WriteLine($"{count}");
// }

//WHILE

// int heroHealth = 10;
// int monsterHealth = 10;

// do {
//     Random attack = new Random();
//     int damage = 0;
//     damage = attack.Next(1,11);
//     monsterHealth -= damage;
//     Console.WriteLine($"Monster was damaged and lost {damage} health and now has {monsterHealth} health.");
//     if(monsterHealth <= 0)
//         Console.WriteLine("Hero wins!");
//     else {
//         damage = attack.Next(1,11);
//         heroHealth -= damage;
//         Console.WriteLine($"Hero was damaged and lost {damage} health and now has {heroHealth} health.");
//         if(heroHealth <= 0)
//             Console.WriteLine("Monster wins!");
//     }
// } while (heroHealth > 0 && monsterHealth > 0);

// using System.ComponentModel.DataAnnotations;

// string? enteredValue;
// int numericValue;
// bool validValue = false;
// Console.WriteLine("Please enter a value between 5 and 10.");

// do {
//     enteredValue = Console.ReadLine();
//     if(!int.TryParse(enteredValue, out numericValue))
//     {
//         Console.WriteLine("Sorry, you entered an invalid number, please try again");
//         continue;
//     }
//     validValue = (numericValue > 4 && numericValue < 11);
//     if (!validValue)
//     {
//         Console.WriteLine($"You entered {numericValue}. Please enter a number between 5 and 10.");
//         continue;
//     }
// } while (!validValue);
// Console.WriteLine($"Your input value ({numericValue}) has been accepted.");

// string? inputValue;
// string[] roles = ["Administrator","Manager","User"];
// bool validRole = false;
// Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
// do {
//     inputValue = Console.ReadLine();
//     if(string.IsNullOrEmpty(inputValue))
//     {
//         Console.WriteLine("You did not enter a value. Enter your role name (Administrator, Manager, or User)");
//         continue;
//     };
//     foreach(string role in roles)
//     {
//         validRole = role.Trim().ToLower() == inputValue.Trim().ToLower();
//         if(validRole) break;
//     };
//     if(!validRole)
//         Console.WriteLine($"The role name that you entered, \"{inputValue}\" is not valid. Enter your role name (Administrator, Manager, or User)");
// } while (!validRole);

// Console.WriteLine($"Your input value ({inputValue}) has been accepted.");

// string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
// int periodLocation = 0;

// foreach(string myString in myStrings)
// {
//     string newString = myString;
//     periodLocation = newString.IndexOf(".");
    
//     while(periodLocation > 0)
//     { 
//         Console.WriteLine(newString.Remove(periodLocation));
//         newString = newString.Substring(periodLocation+1).TrimStart();
//         //Console.WriteLine(newString);
//         periodLocation = newString.IndexOf(".");
//     };
//     Console.WriteLine(newString);
// };