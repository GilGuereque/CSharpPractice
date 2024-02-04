// // Practicing with iteration loops:
// for (int i = 0; i < 10; i++)
// {
//     Console.WriteLine(i);
// }

// for (int i = 10; i >= 0; i--)
// {
//     Console.WriteLine(i);
// }


// // different iteraton:

// for (int i = 0; i < 10; i += 3)
// {
//     Console.WriteLine(i);
// }

// // using break:
// // when counter i reaches 7 loop will break/stop
// for (int i = 0; i < 10; i++)
// {
//     Console.WriteLine(i);
//     if (i == 7) break;
// }

// // iterate through the length of an array:
// // but do it backwards
// string[] names = { "Alex", "Eddie", "David", "Michael" };
// for (int i = names.Length - 1; i >= 0; i--)
// {
//     Console.WriteLine(names[i]);
// }

// Update David with Sammy:
// string[] names = { "Alex", "Eddie", "David", "Michael" };
// for (int i = 0; i < names.Length; i++)
//     if (names[i] == "David") names[i] = "Sammy";

// foreach (var name in names) Console.WriteLine(name);

// // other variation of this code:
// string[] names = { "Alex", "Eddie", "David", "Michael" };

// for (int i = 0; i < names.Length; i++)
// {
//     if (names[i] == "David")
//     {
//         names[i] = "Sammy";
//     }
// }

// foreach (var name in names)
// {
//     Console.WriteLine(name);
// }


// fizzbuzz for loop Challenge:

for (int i = 1; i < 101; i++)
{
    if ( (i % 3 == 0) && (i % 5 == 0))
        Console.WriteLine($"{i} - FizzBuzz");
    else if (i % 3 == 0)
        Console.WriteLine($"{i} - Fizz");
    else if (i % 5 == 0)
    {
        Console.WriteLine($"{i} - Buzz");
    }
    else
        Console.WriteLine(i);
}