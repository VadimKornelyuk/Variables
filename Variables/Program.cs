namespace Task1;

public class Program
{
    public static void Main()
    {
        var a = new ParentClass();
        var b = new ChildClass1();
        var c = new ChildClass2();

        Console.WriteLine("ParentClass:");
        a.Display("value");
        a.Display(1);
        a.Display(0.23452345234523452345);
        a.Display((float)0.5);

        Console.WriteLine("\nChildClass1:");
        b.Display("value");
        b.Display(1);
        b.Display(0.23452345234523452345);
        b.Display((float)0.5);

        Console.WriteLine("\nChildClass2:");
        c.Display("value");
        c.Display(1);
        c.Display(0.23452345234523452345);
        c.Display((float)0.5);
    }
}

public class ParentClass
{
    public void Display<T>(T value)
    {
        SetConsoleColor(value);
        Console.WriteLine(value);
    }

    protected virtual void SetConsoleColor<T>(T value)
    {
    }
}

public class ChildClass1 : ParentClass
{
    protected override void SetConsoleColor<T>(T value)
    {
        switch (value)
        {
            case string:
                Console.ForegroundColor = ConsoleColor.Blue;
                break;
            case int:
                Console.ForegroundColor = ConsoleColor.Red;
                break;
            case double:
                Console.ForegroundColor = ConsoleColor.Green;
                break;
            case float:
                Console.ForegroundColor = ConsoleColor.Yellow;
                break;
        }
    }
}

public class ChildClass2 : ParentClass
{
    protected override void SetConsoleColor<T>(T value)
    {
        switch (value)
        {
            case string:
                Console.ForegroundColor = ConsoleColor.Gray;
                break;
            case int:
                Console.ForegroundColor = ConsoleColor.Magenta;
                break;
            case double:
                Console.ForegroundColor = ConsoleColor.Cyan;
                break;
            case float:
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                break;
        }
    }
}