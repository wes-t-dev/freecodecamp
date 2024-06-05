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


//****Arrays****///

// string[] pallets = { "B14", "A11", "B12", "A13" };

// Console.WriteLine("Sorted...");
// Array.Sort(pallets);
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// Console.WriteLine("");
// Console.WriteLine("Reversed...");
// Array.Reverse(pallets);
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }
// string[] pallets = { "B14", "A11", "B12", "A13" };
// Console.WriteLine("");

// Array.Clear(pallets, 0, 2);
// Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// string pangram = "The quick brown fox jumps over the lazy dog";

// string[] strings = pangram.Split(" ");
// pangram = "";
// for (int i = 0; i < strings.Length; i++) {
//     char[] strarray = strings[i].ToCharArray();
//     Array.Reverse(strarray);
//     foreach(char c in strarray) {
//         pangram += c;
//     }
//     pangram += " ";
// }
// Console.WriteLine(pangram);

// string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

// string[] orderIds = orderStream.Split(",");
// Array.Sort(orderIds);
// foreach (string orderId in orderIds) {
//     if(orderId.Length == 4)
//         Console.WriteLine(orderId);
//     else
//         Console.WriteLine(orderId + "\t- Error");
// }




/****  Create your first Method   *****/


// Console.WriteLine("Generating random numbers:");
// DisplayRandomNumbers();

// void DisplayRandomNumbers() 
// {
//     Random random = new Random();

//     for (int i = 0; i < 5; i++) 
//     {
//         Console.Write($"{random.Next(1, 100)} ");
//     }

//     Console.WriteLine();
// }

//------
// using System;

// int[] times = {800, 1200, 1600, 2000};
// int diff = 0;

// Console.WriteLine("Enter current GMT");
// int currentGMT = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Current Medicine Schedule:");
// DisplayTimes();

// Console.WriteLine();

// Console.WriteLine("Enter new GMT");
// int newGMT = Convert.ToInt32(Console.ReadLine());

// if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
// {
//     Console.WriteLine("Invalid GMT");
// }
// else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0) 
// {
//     diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
//     AdjustTimes();
// } 
// else 
// {
//     diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
//     AdjustTimes();
// }

// Console.WriteLine("New Medicine Schedule:");
// DisplayTimes();

// Console.WriteLine();

// void DisplayTimes() 
// {
//     /* Format and display medicine times */
//     foreach (int val in times)
//     {
//         string time = val.ToString();
//         int len = time.Length;

//         if (len >= 3)
//         {
//             time = time.Insert(len - 2, ":");
//         }
//         else if (len == 2)
//         {
//             time = time.Insert(0, "0:");
//         }
//         else
//         {
//             time = time.Insert(0, "0:0");
//         }

//         Console.Write($"{time} ");
//     }

//     Console.WriteLine();
// }

// void AdjustTimes() 
// {
//     /* Adjust the times by adding the difference, keeping the value within 24 hours */
//     for (int i = 0; i < times.Length; i++) 
//     {
//         times[i] = ((times[i] + diff)) % 2400;
//     }
// }
//------

/*
if ipAddress consists of 4 numbers
and
if each ipAddress number has no leading zeroes
and
if each ipAddress number is in range 0 - 255

then ipAddress is valid

else ipAddress is invalid
*/

// string[] ipv4Input = {"107.31.1.5", "255.0.0.255", "555..0.555", "255...255"};
// string[] address;
// bool validLength = false;
// bool validZeroes = false;
// bool validRange = false;

// foreach (string ip in ipv4Input) 
// {
//     address = ip.Split(".", StringSplitOptions.RemoveEmptyEntries);
    
//     ValidateLength(); 
//     ValidateZeroes(); 
//     ValidateRange();

//     if (validLength && validZeroes && validRange) 
//     {
//         Console.WriteLine($"{ip} is a valid IPv4 address");
//     } 
//     else 
//     {
//         Console.WriteLine($"{ip} is an invalid IPv4 address");
//     }
// }

// void ValidateLength() 
// {
//     validLength = address.Length == 4;
// };

// void ValidateZeroes() 
// {
//     foreach (string number in address) 
//     {
//         if (number.Length > 1 && number.StartsWith("0")) 
//         {
//             validZeroes = false;
//             return;
//         }
//     }

//     validZeroes = true;
// }

// void ValidateRange() 
// {
//     foreach (string number in address) 
//     {
//         int value = int.Parse(number);
//         if (value < 0 || value > 255) 
//         {
//             validRange = false;
//             return;
//         }
//     }
//     validRange = true;
// }

//----------

//Code challenge: create a reusable method

Random random = new Random();
int luck = random.Next(100);

string[] text = {"You have much to", "Today is a day to", "Whatever work you do", "This is an ideal time to"};
string[] good = {"look forward to.", "try new things!", "is likely to succeed.", "accomplish your dreams!"};
string[] bad = {"fear.", "avoid major decisions.", "may have unexpected outcomes.", "re-evaluate your life."};
string[] neutral = {"appreciate.", "enjoy time with friends.", "should align with your values.", "get in tune with nature."};

tellFortune();

void tellFortune() {
    Console.WriteLine("A fortune teller whispers the following words:");
    string[] fortune = (luck > 75 ? good : (luck < 25 ? bad : neutral));
    for (int i = 0; i < 4; i++) 
    {
        Console.Write($"{text[i]} {fortune[i]} ");
    }
}