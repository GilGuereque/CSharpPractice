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

// Remove the curly braces
bool flag = true;
if (flag)
    Console.WriteLine(flag);