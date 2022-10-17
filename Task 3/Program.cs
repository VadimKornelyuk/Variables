public class Program
{
    public static void Main()
    {
        var intChildClass = new IntChildClass();
        var stringChildClass = new StringChildClass();
        var doubleChildClass = new DoubleChildClass();

        Console.WriteLine(intChildClass.Value);
        Console.WriteLine(stringChildClass.Value);
        Console.WriteLine(doubleChildClass.Value);
    }

    public class BaseClass
    {
        private const int _integer = 1;
        private const string _string = "abc";
        private const double _double = 0.1;

        protected static int Integer => _integer;

        protected static string @String => _string;

        protected static double @Double => _double;
    }

    public class IntChildClass : BaseClass
    {
        public int Value => Integer;
    }

    public class StringChildClass : BaseClass
    {
        public string Value => @String;
    }

    public class DoubleChildClass : BaseClass
    {
        public double Value => @Double;
    }
}

