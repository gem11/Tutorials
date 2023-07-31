using System;

namespace Exceptions
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Depending on the Exception handling settings in Visual Studio
            // execution of this program can be interrupted. In this case press
            // F5 to continue with the program flow.
            try
            {
                Console.WriteLine("Trying to call a method..");
                DoSomething();
                Console.WriteLine("Finished doing something.");
            }
            catch(Exception e)
            {
                Console.WriteLine("Did not finish the try block. Exception occured:");
                Console.WriteLine(e.ToString());
            }
            finally
            {
                Console.WriteLine("Coming here whatever happens.");
            }
        }

        public static void DoSomething()
        {
            // Try and replace the next line with Console.WriteLine
            throw new Exception("Something went wrong :-(");
        }
    }
}
