// example of exception handling:
// try
// {   
//    // try code block - code that may generate an exception
// }
// catch
// {   
//    // catch code block - code to handle an exception
// }
// finally
// {   
//    // finally code block - code to clean up resources
// }

// // try-finally nested inside a try-catch
// try
// {
//     // Step 1: code execution begins
//     try
//     {
//         // Step 2: an exception occurs here
//     }
//     finally
//     {
//         // Step 4: the system executes the finally code block associated with the try statement where the exception occurred
//     }

// }
// catch // Step 3: the system finds a catch clause that can handle the exception
// {   
//    // Step 5: the system transfers control to the first line of the catch code block
// }


// // implement try catch
// double float1 = 3000.0;
// double float2 = 0.0;
// int number1 = 3000;
// int number2 = 0;

// try 
// {
//     Console.WriteLine(float1 / float2);
//     Console.WriteLine(number1 / number2);
// }
// catch 
// {
//     Console.WriteLine("Exit program");
// }

// try
// {
//     Process1();
// }
// catch
// {
//     Console.WriteLine("An exception has occurred");
// }

// Console.WriteLine("Exit program");

// static void Process1()
// {
//     WriteMessage();
// }

// static void WriteMessage()
// {
//     double float1 = 3000.0;
//     double float2 = 0.0;
//     int number1 = 3000;
//     int number2 = 0;

//     Console.WriteLine(float1 / float2);
//     Console.WriteLine(number1 / number2);
// }


// try
// {
//     Process1();
// }
// catch
// {
//     Console.WriteLine("An exception has occurred");
// }

// Console.WriteLine("Exit program");

// static void Process1()
// {
//     try
//     {
//         WriteMessage();
//     }
//     catch (DivideByZeroException ex)
//     {
//         Console.WriteLine($"Exception caught in Process1: {ex.Message}");
//     }
// }

// static void WriteMessage()
// {
//     double float1 = 3000.0;
//     double float2 = 0.0;
//     int number1 = 3000;
//     int number2 = 0;
//     byte smallNumber;

//     Console.WriteLine(float1 / float2);
//     // Console.WriteLine(number1 / number2);
//     checked
//     {
//         smallNumber = (byte)number1;
//     }
// }


// inputValues is used to store numeric values entered by a user
string[] inputValues = new string[]{"three", "9999999999", "0", "2" };

foreach (string inputValue in inputValues)
{
    int numValue = 0;
    try
    {
        numValue = int.Parse(inputValue);
    }
    catch (FormatException)
    {
        Console.WriteLine("Invalid readResult. Please enter a valid number.");
    }
    catch (OverflowException)
    {
        Console.WriteLine("The number you entered is too large or too small.");
    }
    catch(Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}