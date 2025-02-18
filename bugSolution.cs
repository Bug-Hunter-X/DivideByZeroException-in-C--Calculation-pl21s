public class ExampleClass
{
    public int Calculate(int a, int b)
    {
        try
        {
            return a / b; 
        }
        catch (DivideByZeroException ex)
        {
            // Handle the exception appropriately.  Log the error, return a default value, or throw a custom exception.
            Console.WriteLine($"An error occurred: {ex.Message}");
            return 0; // Or throw a custom exception
        }
    }
}