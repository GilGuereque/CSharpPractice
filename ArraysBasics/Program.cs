/*
// Declare Arrays & Practice
string[] fraudulentOrderIDs = new string[3];
// Assign Order ID values to array
fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";
// Attempt to break the array
// fraudulentOrderIDs[3] = "D000";
*/

/*
// Initialize an array with values:
string[] fraudulentOrderIDs = {"A123","B456","C789"};
// Retrieve values from the array:
Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

// Reassign the value of an array
fraudulentOrderIDs[0] = "F000";
Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

// Length property of an array:
Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");

// Foreach statement in Arrays
string [] names = {"Rowena","Robin","Bao"};
foreach (string name in names)
{
    Console.WriteLine(name);
}
*/

// Exercise for Foreach Challenge
// create the array
int[] inventory = { 200, 450, 700, 175, 250 };

int sum = 0;
int bin = 0;

foreach (int item in inventory)
{
    // Console.WriteLine(item);
    sum += item;
    bin++;
    Console.WriteLine($"Bin {bin} = {item} items (Running total: {sum})");
}

// Display the final value of the sum:
Console.WriteLine($"We have {sum} items in our inventory.");


