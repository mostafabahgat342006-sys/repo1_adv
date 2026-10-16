namespace c__Advanced_ass1;

public class Program
{

    public static void Swap<T>(ref T a, ref T b)
    {
        T temp = a;
        a = b;
        b = temp;
    }





    static void Main(string[] args)
    {

        /*
             Q1- generic class is a class that can work with different data types using a 
                   type parameter like <T>, without repetition the code.

                   1- Type Safety: Prevents type errors at compile time.

                   2- Reusability: Write code once and use it with different data types.

                   3- Better Performance: Avoids boxing and unboxing.

                   4- Cleaner Code: Reduces code duplication.






             Q3- Multiple type parameters allow a generic class to work 
                  with more than one data type at the same time.





            Q4- A generic method is a method that can work with different data types using a type parameter <T>.

        */


        int x = 10;
        int y = 20;

        Swap(ref x, ref y);

        Console.WriteLine(x);
        Console.WriteLine(y);

    }


    
}      










