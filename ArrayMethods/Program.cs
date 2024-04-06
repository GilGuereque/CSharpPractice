﻿// // exercise creating array of pallets
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
decimal price = 67.55m;
decimal salePrice = 59.99m;
decimal discount = (price - salePrice) / price;

string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price.", (price - salePrice), price);

Console.WriteLine(yourDiscount);
Console.WriteLine($"A total of {discount:P2} in savings.");