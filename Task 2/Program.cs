public class Program
{
    public static void Main()
    {
        var bList = new List<B>()
                {
                    new B1(), new B2(), new B3()
                };

        var a = new A(bList);

        a.WriteClassesInfo();
    }

    public class B1 : B
    {
        public override void VoidMethod()
        {
            Console.WriteLine($"This is {nameof(VoidMethod)} method of {nameof(B1)} class.");
        }

        public override int IntMethod(int value)
        {
            Console.WriteLine($"This is {nameof(IntMethod)} method of {nameof(B1)} class that returns {value}.");
            return value;
        }

        public override string StringMethod(string value)
        {
            Console.WriteLine($"This is {nameof(StringMethod)} method of {nameof(B1)} class that returns {value}.");
            return value;
        }
    }

    public class B2 : B
    {
        public override void VoidMethod()
        {
            Console.WriteLine($"This is {nameof(VoidMethod)} method of {nameof(B2)} class.");
        }

        public override int IntMethod(int value)
        {
            Console.WriteLine($"This is {nameof(IntMethod)} method of {nameof(B2)} class that returns {value}.");
            return value;
        }

        public override string StringMethod(string value)
        {
            Console.WriteLine($"This is {nameof(StringMethod)} method of {nameof(B2)} class that returns {value}.");
            return value;
        }
    }

    public class B3 : B
    {
        public override void VoidMethod()
        {
            Console.WriteLine($"This is {nameof(VoidMethod)} method of {nameof(B3)} class.");
        }

        public override int IntMethod(int value)
        {
            Console.WriteLine($"This is {nameof(IntMethod)} method of {nameof(B3)} class that returns {value}.");
            return value;
        }

        public override string StringMethod(string value)
        {
            Console.WriteLine($"This is {nameof(StringMethod)} method of {nameof(B3)} class that returns {value}.");
            return value;
        }
    }

    public abstract class B
    {
        public abstract void VoidMethod();

        public abstract int IntMethod(int value);

        public abstract string StringMethod(string value);
    }

    public class A
    {
        private readonly List<B> _bClasses;

        public A(List<B> bClasses)
        {
            _bClasses = bClasses;
        }

        public void WriteClassesInfo()
        {
            Console.WriteLine($"Class A received {_bClasses.Count} B classes.\n");

            foreach (var b in _bClasses)
            {
                Console.WriteLine($"B class number {_bClasses.IndexOf(b) + 1} has type {b.GetType()} and name {nameof(b)}. Here is detailed info about this member:");
                Console.WriteLine($"{nameof(b.VoidMethod)} execution result:");
                b.VoidMethod();
                Console.WriteLine($"{nameof(b.IntMethod)} execution result:");
                b.IntMethod(1);
                Console.WriteLine($"{nameof(b.StringMethod)} execution result:");
                b.StringMethod("abc");
                Console.WriteLine("\n");
            }
        }
    }
}