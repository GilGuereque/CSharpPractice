// // exercise creating array of pallets
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
// foreach ( var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// string[] pallets = { "B14", "A11", "B12", "A13" };
// Console.WriteLine("");

// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"Before: {pallet}");
// }

// Array.Clear(pallets, 0, 2);

// Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// Console.WriteLine("");
// Array.Resize(ref pallets, 6);
// Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

// pallets[4] = "C01";
// pallets[5] = "C02";

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

// Console.WriteLine("");
// Array.Resize(ref pallets, 6);
// Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

// pallets[4] = "C01";
// pallets[5] = "C02";

// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// Console.WriteLine("");
// Array.Resize(ref pallets, 3);
// Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// // Using ToCharArray() & Reverse()
// string value = "abc123";
// char[] valueArray = value.ToCharArray();
// Array.Reverse(valueArray);
// string result = new string(valueArray);
// Console.WriteLine(result);

// // Using Split() & Join()
// string value2 = "abc123";
// char[] valueArray2 =  value2.ToCharArray();
// Array.Reverse(valueArray2);
// string result2 = string.Join(",", valueArray2);
// Console.WriteLine(result2);

// string value = "abc123";
// char[] valueArray = value.ToCharArray();
// Array.Reverse(valueArray);
// // string result = new string(valueArray);
// string result = string.Join(",", valueArray);
// Console.WriteLine(result);

// string[] items = result.Split(',');
// foreach (string item in items)
// {
//     Console.WriteLine(item);
// }


// Write code to reverse each word in a message
// string pangram = "The quick brown fox jumps over the lazy dog";
// char[] pangramArray = pangram.ToCharArray();
// string result = string.Split(",", pangramArray);
// Array.Reverse(pangramArray);
// Console.WriteLine(pangramArray);


// string pangram = "The quick brown fox jumps over the lazy dog";

// // Step 1
// string[] message = pangram.Split(' ');

// //Step 2
// string[] newMessage = new string[message.Length];

// // Step 3
// for (int i = 0; i < message.Length; i++)
// {
//     char[] letters = message[i].ToCharArray();
//     Array.Reverse(letters);
//     newMessage[i] = new string(letters);
// }

// //Step 4
// string result = String.Join(" ", newMessage);
// Console.WriteLine(result);

// Parse a string of orders, sort orders and tag possible errors
// string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
// string[] items = orderStream.Split(',');
// Console.WriteLine(items);
// Console.WriteLine(orderStream[1]);
// // Array.Sort(items);
// string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
// string[] items = orderStream.Split(',');
// Array.Sort(items);

// foreach (var item in items)
// {
//     if (item.Length == 4)
//     {
//         Console.WriteLine(item);
//     }
//     else
//     {
//         Console.WriteLine(item + "\t- Error");
//     }
// }


// // Leetcode Two Sum solution:

// // my solution:
// public class Solution {
//     public int[] TwoSum(int[] nums, int target) {
//         int sum = 0;
//         foreach (int num in nums)
//         {
//             if (num + num == target)
//             {
//                 sum = num + num;
//             }
//         }
//         Console.WriteLine(sum);
//     }
// }

// // correct solution:
// public class Solution {
//     public int[] TwoSum(int[] nums, int target) {
//         for (int i = 0; i < nums.Length; i++) {
//             for (int j = i + 1; j < nums.Length; j++) {
//                 if (nums[i] + nums[j] == target) {
//                     return new int[] { i, j };
//                 }
//             }
//         }
//         throw new ArgumentException("No two sum solution");
//     }
// }


// // Composite formatting in Strings
// string first = "Hello";
// string second = "World";
// string result = string.Format("{0} {1}", first, second);
// Console.WriteLine(result);

// // changing up the order:
// string first = "Hello";
// string second = "World";
// Console.WriteLine("{1} {0}!", first, second);
// Console.WriteLine("{0} {0} {0}!", first, second);

// // String interpolation
// string first = "Hello";
// string second = "World";
// Console.WriteLine($"{first} {second}");
// Console.WriteLine($"{second} {first}");
// Console.WriteLine($"{first} {first} {first}");

// // formatting currency
// decimal price = 123.45m;
// int discount = 50;
// Console.WriteLine($"Price: {price:C} (Save {discount:C})");

// // formatting numbers
// decimal measurement = 123456.78912m;
// Console.WriteLine($"Measurement: {measurement:N4} units");

// formatting percentages:
// decimal tax = .36785m;
// Console.WriteLine($"Tax rate: {tax:P2}");

// combining formatting approaches:
// decimal price = 67.55m;
// decimal salePrice = 59.99m;
// decimal discount = (price - salePrice) / price;

// string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price.", (price - salePrice), price);

// Console.WriteLine(yourDiscount);
// Console.WriteLine($"A total of {discount:P2} in savings.");

// // Another option:
// decimal price = 67.55m;
// decimal salePrice = 59.99m;

// string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price);

// yourDiscount += $"A discount of {((price - salePrice)/price):P2}!"; //inserted
// Console.WriteLine(yourDiscount);

// int invoiceNumber = 1201;
// decimal productShares = 25.4568m;
// decimal subtotal = 2750.00m;
// decimal taxPercentage = .15825m;
// decimal total = 3185.19m;

// Console.WriteLine($"Invoice Number: {invoiceNumber}");
// Console.WriteLine($"   Shares: {productShares:N3} Product");
// Console.WriteLine($"     Sub Total: {subtotal:C2}");
// Console.WriteLine($"\t   Tax: {taxPercentage:P2}");
// Console.WriteLine($"  Total Billed: {total:C}");

// // formatting strings with padding
// string input = "Pad Thai";
// // Console.WriteLine(input.PadLeft(12)); //makes string 12 characters total with 4 whitespaces on left
// // Console.WriteLine(input.PadRight(12)); //makes string 12 characters total with 4 whitespaces on right

// Console.WriteLine(input.PadLeft(12, '-'));
// Console.WriteLine(input.PadRight(12, '-'));

// string paymentId = "769C";
// string payeeName = "Mr. Stephen Ortega";
// string paymentAmount = "$5,000.00";

// var formattedLine = paymentId.PadRight(6);
// formattedLine += payeeName.PadRight(24);
// formattedLine += paymentAmount.PadLeft(10);

// Console.WriteLine("1234567890123456789012345678901234567890");
// Console.WriteLine(formattedLine);

// // use string interpolation and formatting exercise:
// string customerName = "Ms. Barros";

// string currentProduct = "Magic Yield";
// int currentShares = 2975000;
// decimal currentReturn = 0.1275m;
// decimal currentProfit = 55000000.0m;

// string newProduct = "Glorious Future";
// decimal newReturn = 0.13125m;
// decimal newProfit = 63000000.0m;

// Console.WriteLine($"Dear {customerName}");
// Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.");
// Console.WriteLine($"\nCurrently, you own {currentShares:N2} shares at a return of {currentReturn:P2}.\n");
// Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P2}.  Given your current volume, your potential profit would be {newProfit:C}");

// Console.WriteLine("Here's a quick comparison:\n");

// string comparisonMessage = "";

// comparisonMessage = currentProduct.PadRight(20);
// comparisonMessage += String.Format("{0:P}", currentReturn).PadRight(10);
// comparisonMessage += String.Format("{0:C}", currentProfit).PadRight(20);

// comparisonMessage += "\n";
// comparisonMessage += newProduct.PadRight(20);
// comparisonMessage += String.Format("{0:P}", newReturn).PadRight(10);
// comparisonMessage += String.Format("{0:C}", newProfit).PadRight(20);

// Console.WriteLine(comparisonMessage);

// // find parenthesis pairs embedded in a string
// string message = "Find what is (inside the parentheses)";

// int openingPosition = message.IndexOf('(');
// int closingPosition = message.IndexOf(')');

// // Console.WriteLine(openingPosition);
// // Console.WriteLine(closingPosition);

// // int length = closingPosition - openingPosition;
// // Console.WriteLine(message.Substring(openingPosition + 1, length - 1));
// // Console.WriteLine(length);

// // or you can also do this:
// openingPosition += 1;

// int length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition, length));

// string message = "What is the value <span>between the tags</span>?";

// int openingPosition = message.IndexOf("<span>");
// int closingPosition = message.IndexOf("</span>");

// openingPosition += 6;
// int length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition, length));

// string message = "What is the value <span>between the tags</span>?";

// const string openSpan = "<span>";
// const string closeSpan = "</span>";

// int openingPosition = message.IndexOf(openSpan);
// int closingPosition = message.IndexOf(closeSpan);

// openingPosition += openSpan.Length;
// int length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition, length));

// // Exercise for indexyofany and lastindexof
// string message = "(What if) I am (only interested) in the last (set of parentheses)?";
// int openingPosition = message.LastIndexOf('(');
// Console.WriteLine(openingPosition);
// openingPosition += 1;
// int closingPosition = message.LastIndexOf(')');
// int length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition, length));

// Retrieve all instance of substrings inside parentheses:
string message = "(What if) there are (more than) one (set of parentheses)?";
List<string> messages = new List<string>(); // create a list to store substrings

while (true)
{
    int openingPosition = message.IndexOf('(');
    if (openingPosition == -1) break; // no more opening parentheses (exit loop)

    openingPosition += 1; // move past the opening parenthesis
    int closingPosition = message.IndexOf(')'); // find closing parenthesis
    if (closingPosition == -1) break; // Safety check for mismatched parentheses

    int length = closingPosition - openingPosition; // calculate length of substring
    Console.WriteLine(message.Substring(openingPosition, length)); // display substring
    messages.Add(message.Substring(openingPosition, length)); // store substring in array
    // Note the overload of the Substring to return only the remaining 
    // unprocessed message:
    message = message.Substring(closingPosition + 1);
}

foreach (var msg in messages)
{
    Console.WriteLine(msg);
}