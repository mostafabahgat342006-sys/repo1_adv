using System.Net.WebSockets;

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

    public class Student : IPrintable
    {
        public Student()
        {
        }

        public void Print()
        {
            Console.WriteLine("Student Info");
        }
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



           Q7- The struct constraint ensure that the generic type <T> must be value type
                such as int, double, bool, or a struct.
            

              
           Q8- The class constraint ensures that the generic type T must be a reference type
                 such as a class or string.




          Q9- The new() constraint ensure that the generic type T must have a 
               public parameterless constructor ( constructor with no parameters).



          Q10- interface constraint ensure that the generic type T must implement a specific interface.


          Q11- The base class constraint ensure that the generic type T must
                 inherit from a specific base class or be that base class itself.


          




        */


        int x = 10;
        int y = 20;

        Swap(ref x, ref y);

        Console.WriteLine(x);
        Console.WriteLine(y);

        Console.WriteLine("-------------------------------------");

        Console.WriteLine(FindMax(10, 20));
        Console.WriteLine(FindMax(5.5, 3.2));

        Console.WriteLine("-------------------------------------");


        Console.WriteLine("struct constraint :");
        Container<int> c1 = new Container<int>();
        c1.Value = 10;

        Console.WriteLine(c1.Value);

        Console.WriteLine("-------------------------------------");


        Console.WriteLine("class constraint :");
        Container2<string> c2 = new Container2<string>();
        c2.Value = "Hello";

        Console.WriteLine(c1.Value);


        Console.WriteLine("-------------------------------------");

        Console.WriteLine("new() constraint :");


        Container3<Student> c3 = new Container3<Student>();

        Student s = c3.Create();
        Console.WriteLine("done ");


        Console.WriteLine("-------------------------------------");


        Console.WriteLine("interface constraint :");


        Container4<Student> c4 = new Container4<Student>();

        c4.Show(new Student());


    }


    
}      










