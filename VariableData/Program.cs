// // Working with Variable Data in C# Module Exercises:
// Console.WriteLine("Signed integral types:");

// Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
// Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
// Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
// Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");
// Console.WriteLine("");
// Console.WriteLine("Unsigned integral types:");

// Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
// Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
// Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
// Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");

// // floating point numbers
// Console.WriteLine("");
// Console.WriteLine("Floating point types:");
// Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
// Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
// Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");

// Reference Data Types
// int[] data = new int[3];

// Casting & Converting Data Types
// int first = 2;
// string second = "4";
// int result = first + second;
// Console.WriteLine(result); //could not convert the string variable to an int


// since you are using a string for the result variable this works
// int first = 2;
// string second = "4";
// string result = first + second;
// Console.WriteLine(result);

// Is it possible to change the value's data type and result 
// // in a loss of information?
// int myInt = 3;
// Console.WriteLine($"int: {myInt}");

// decimal myDecimal = myInt;
// Console.WriteLine($"decimal: {myDecimal}");

// // Perform a Cast
// decimal myDecimal = 3.14m;
// Console.WriteLine($"decimal: {myDecimal}");

// int myInt = (int)myDecimal;
// Console.WriteLine($"int: {myInt}");

// // Precision changes in narrowing & widening conversions
// decimal myDecimal = 1.23456789m;
// float myFloat = (float)myDecimal;

// Console.WriteLine($"decimal: {myDecimal}");
// Console.WriteLine($"float  : {myFloat}"); // you lost precision of one decimal


// // Performing Data Conversions with methods
// int first = 5;
// int second = 7;
// string message = first.ToString() + second.ToString();
// Console.WriteLine(message);

// Use the Parse method, can also use TryParse which is the better method
// string first = "5";
// string second = "7";
// int sum = int.Parse(first) + int.Parse(second);
// Console.WriteLine(sum);

// // Convert strings to int using Convert class
// string value1 = "5";
// string value2 = "7";
// int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
// Console.WriteLine(result);

// // narrowing conversions with Convert
// int value = (int)1.5m; // casting truncates
// Console.WriteLine(value);

// int value2 = Convert.ToInt32(1.5m); // converting rounds up
// Console.WriteLine(value2);

// using the TryParse method
// TryParse takes in the value of 102 which is a string
// and spits out the result that was 0, but instead 102 as an int
// string value = "102";
// string value = "bad";
// int result = 0;
// if (int.TryParse(value, out result))
// {
//     Console.WriteLine($"Measurement: {result}");
// }
// else
// {
//     Console.WriteLine("Unable to report the measurement.");
// }
// if (result > 0)
//     Console.WriteLine($"Measurement (w/ offset): {50 + result}");

// // Exercise to separate string data
// string[] values = {"12.3", "45","ABC","11","DEF"};
// string message = "";
// decimal total = 0m;

// foreach (var n in values)
// {
//     decimal number; // stores the TryParse "out" value
//     if (decimal.TryParse(n, out number))
//     {
//         total += number;
//     } else
//     {
//         message += n;
//     }
// }
// Console.WriteLine($"Message: {message}");
// Console.WriteLine($"Total: {total}");

// Excercise - Complete challenge to output math operations
// as a specific number types
int value1 = 12;
decimal value2 = 6.2m;
float value3 = 4.3f;

// The Convert class is best for converting the fractional decimal numbers into whole integer numbers
// Convert.ToInt32() rounds up the way you would expect.
int result1 = Convert.ToInt32(value1 / value2); // Your code here to set result1
// Hint: You need to round the result to nearest integer (don't just truncate)
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

decimal result2 = value2 / (decimal)value3; // Your code here to set result2
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

float result3 = value3 / value1; // Your code here to set result3
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");
