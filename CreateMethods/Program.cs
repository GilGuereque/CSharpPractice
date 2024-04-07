// developing the method signature:
// return type of void meaning the method returns no data
// however methods can return a value of any data type, such as bool, int, double, and arrays as well
// // you must add a method definition using {} brackets before you can run a method
// SayHello();

// void SayHello()
// {
//     Console.WriteLine("Hello World!");
// }

// notice it isn't necessary to define the method before you call it
// it is actually common to call the method and define your methods at the end of a program
// example
int [] a = {1,2,3,4,5};
PrintArray();

void PrintArray()
{
    foreach (int x in a)
    {
        Console.WriteLine(x);
    }
    Console.WriteLine();
}

// Method execution
Console.WriteLine("Before calling a method");
SayHello();
Console.WriteLine("After calling a method");

void SayHello()
{
    Console.WriteLine("Hello World!");
}

// Best practices:
/*
When choosing a method name, it's important to keep the name consise and make it clear what task the method performs
Method names should be Pascal case and generally shouldn't start with digits. Names for parameters should describe
what kind of info the parameter represents
*/
void ShowData(string a, int b, int c);
void DisplayData(string month, int day, int year);