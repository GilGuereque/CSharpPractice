// // exploring global and local variable scopes
// // create a variable inside of a code block
// bool flag = true;
// int value = 10;

// if (flag)
// {
//     Console.WriteLine($"Inside the code block: {value}");
// }

// Console.WriteLine($"Outside the code block: {value}");

// // Using if statements in a code block with or without curly braces:
// bool flag = true;
// if (flag)
// {
//     Console.WriteLine(flag);
// }

// // Remove the curly braces
// bool flag = true;
// if (flag)
//     Console.WriteLine(flag);

// // Another more readable example with single line if else statements:
// string name = "steve";

// if (name == "bob")
//     Console.WriteLine("Found Bob");
// else if (name == "steve") 
//     Console.WriteLine("Found Steve");
// else
//     Console.WriteLine("Found Chuck");


// // Code challenge for Variable Scope (my solution):
// int[] numbers = { 4, 8, 15, 16, 23, 42 };

// foreach (int number in numbers)
// {
//     int total;

//     total = 0;

//     total += number;

//     if (number == 42)
//     {
//         bool found = true;

//         if (found)
//         {
//             Console.WriteLine("Set contains 42");
//         }
//     } 

//     Console.WriteLine($"Total: {total}");
// }


// // Microsoft Solution:
// int[] numbers = { 4, 8, 15, 16, 23, 42 };
// int total = 0;
// bool found = false;

// foreach (int number in numbers)
// {
//     total += number;
//     if (number == 42)
//         found = true;
// }

// if (found)
//     Console.WriteLine("Set contains 42");

// Console.WriteLine($"Total: {total}");


// // Switch Case Constructs:
// switch (fruit)
// {
//     case "apple":
//         Console.WriteLine($"App will display information for apple.");
//         break;

//     case "banana":
//         Console.WriteLine($"App will display information for banana.");
//         break;

//     case "cherry":
//         Console.WriteLine($"App will display information for cherry.");
//         break;
// }

// // My switch case example
// int employeeLevel = 100;
// string employeeName = "John Smith";

// string title = "";

// switch (employeeLevel)
// {
//     case 100:
//     case 200:
//         title = "Senior Associate";
//         break;
//     case 300:
//         title = "Manage";
//         break;
//     case 400:
//         title = "Senior Manager";
//         break;
//     default:
//         title = "Associate";
//         break;
// }

// Console.WriteLine($"{employeeName}, {title}");


// Challenge for Switch Case:
// SKU = Stock Keeping Unit. 
// SKU value format: <product #>-<2-letter color code>-<size code>
string sku = "01-MN-L";

string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";

switch (product[0])
{
    case "01":
        type = "Sweat shirt";
        break;
    
    case "02":
        type = "T-Shirt";
        break;

    case "03":
        type = "Sweat pants";
        break;

    default:
        type = "Other";
        break;
}

switch (product[1])
{
    case "BL":
        color = "Black";
        break;

    case "MN":
        color = "Maroon";
        break;

    default:
        color = "White";
        break;
}

switch (product[2])
{
    case "S":
        size = "Small";
        break;

    case "M":
        size = "Medium" ;
        break;

    case "L":
        size = "Large";
        break;

    default:
        size = "One Size Fits All";
        break;
} 

Console.WriteLine($"Product: {size} {color} {type}");