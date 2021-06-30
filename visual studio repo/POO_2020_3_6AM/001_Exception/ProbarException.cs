using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Exception
{
    class ProbarException
    {
        #region
        //public static void Main()
        //{
        //    int number1 = 3000;
        //    int number2 = 0;
        //    try
        //    {
        //        Console.WriteLine(number1 / number2);
        //    }
        //    catch (DivideByZeroException)
        //    {
        //        Console.WriteLine("Division of {0} by zero.", number1);
        //    }
        //    Console.ReadKey();
        //}
        #endregion
        #region 
        //public static void Main()
        //{
        //    int number1 = 3000;
        //    int number2 = 0;

        //    Console.WriteLine((double)number1 / number2);
        //}
        #endregion
        #region Overflow
        //public static void Main()
        //{
        //    int value = 780_000_000;
        //    checked
        //    {
        //        try
        //        {
        //            // Square the original value.
        //            int square = value * value;
        //            Console.WriteLine("{0} ^ 2 = {1}", value, square);
        //        }
        //        catch (OverflowException)
        //        {
        //            double square = Math.Pow(value, 2);
        //            Console.WriteLine("Exception: {0} > {1:E}.",
        //                              square, Int32.MaxValue);
        //        }
        //    }
        //    Console.ReadKey();
        //}
        #endregion
        #region Overflow1.1
        //public static void Main()
        //{
        //    byte value = 241;
        //    checked
        //    {
        //        try
        //        {
        //            sbyte newValue = (sbyte)value;
        //            Console.WriteLine("Converted the {0} value {1} to the {2} value {3}.",
        //                              value.GetType().Name, value,
        //                              newValue.GetType().Name, newValue);
        //        }
        //        catch (OverflowException)
        //        {
        //            Console.WriteLine("Exception: {0} > {1}.", value, SByte.MaxValue);
        //        }
        //    }
        //    Console.ReadLine();
        //}
        #endregion
        #region ArgumentException
        //public static void Main()
        //{
        //    // Define some integers for a division operation.
        //    int[] values = { 10, 7 };
        //    foreach (var value in values)
        //    {
        //        try
        //        {
        //            Console.WriteLine("{0} divided by 2 is {1}", value, DivideByTwo(value));
        //        }
        //        catch (ArgumentException e)
        //        {
        //            Console.WriteLine("{0}: {1}", e.GetType().Name, e.Message);
        //        }
        //        Console.WriteLine();
        //    }
        //    Console.ReadKey();
        //}
        //static int DivideByTwo(int num)
        //{
        //    // If num is an odd number, throw an ArgumentException.
        //    if ((num & 1) == 1)
        //        throw new ArgumentException(String.Format("{0} is not an even number", num),
        //                                  "num");

        //    // num is even, return half of its value.
        //    return num / 2;
        //}

        #endregion
        #region ArgumentException1.1
        public static void Main()
        {
            // Define some integers for a division operation.
            object[] values = { 10, null, 7 };
            foreach (var value in values)
            {
                try
                {
                    Console.WriteLine("{0} divided by 2 is {1}", value, DivideByTwo(value));
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine("{0}: {1}", e.GetType().Name, e.Message);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
        static int DivideByTwo(object num)
        {
            if (num == null)
                throw new ArgumentException();
            int dato = (int)num;
            // If num is an odd number, throw an ArgumentException.
            if ((dato & 1) == 1)
                throw new ArgumentException(String.Format("{0} is not an even number", dato),
                                          "num");

            // num is even, return half of its value.
            return dato / 2;
        }

        #endregion
    }
}
