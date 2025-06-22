﻿using System;

namespace TryCatchErrors.Exercise
{
    public static class ExceptionsDivisionExercise
    {
        public static int DivideNumbers(int a, int b)
        {
            try
            {
                return a / b;
            }
            catch
            {
                Console.WriteLine($"Division by zero.");
                return 0;
            }
            finally
            {
                Console.WriteLine($"The {nameof(DivideNumbers)} method ends.");
            }
        }
    }
}