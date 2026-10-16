namespace c__Advanced_ass1;

public class Program
{

    public static void Swap<T>(ref T a, ref T b)
    {
        T temp = a;
        a = b;
        b = temp;
    }

    public static T FindMax<T>(T a, T b) where T : IComparable<T>
    {
        if (a.CompareTo(b) > 0)
            return a;
        else
            return b;
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

            
            Q6- A generic interface is an interface that uses a type parameter <T> to work 
                 with different data types while maintaining a code reusability.


        */


        int x = 10;
        int y = 20;

        Swap(ref x, ref y);

        Console.WriteLine(x);
        Console.WriteLine(y);

        Console.WriteLine("-------------------------------------");

        Console.WriteLine(FindMax(10, 20));
        Console.WriteLine(FindMax(5.5, 3.2));



    }


    
}      










