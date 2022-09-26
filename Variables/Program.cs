// See https://aka.ms/new-console-template for more information
namespace Variables;
/*public class Program
{
    public static void Main()
    {
        var address1 = new Address();
        address1.Index = 45200;
        address1.Country = "Ukraine";
        address1.City = "Kivertsi";
        address1.Street = "Kyivska";
        address1.House = "5";
        address1.Apartment = null;
        Console.WriteLine($"index: {address1.Index}\ncountry : {address1.Country}\ncity : {address1.City}\nstreet : {address1.Street}\nhouse : {address1.House}\napartment : {address1.Apartment}");


    }

    public class Address
    {
        private int _index;
        private string _country;
        private string _city;
        private string _street;
        private string _house;
        private int? _apartment;

        public int Index
        {
            get => _index;
            set => _index = value;
        }

        public string Country
        {
            get => _country;
            set => _country = value;
        }
        public string City
        {
            get => _city;
            set => _city = value;
        }
        public string Street
        {
            get => _street;
            set => _street = value;
        }
        public string House
        {
            get => _house;
            set => _house = value;
        }
        public int? Apartment
        {
            get => _apartment;
            set => _apartment = value;
        }
    }
}*/

/*public class Program
{
    public static void Main()
    {
        var conv = new Converter(0.027, 0.028, 0.13);
        Console.WriteLine("Select currency pair\nUAH -> USD: 1\nUSD -> UAH: 2\nUAH -> EUR: 3\nEUR -> UAH: 4\nUAH -> PLN: 5\nPLN -> UAH: 6");
        var userSelection = Console.ReadLine() ?? string.Empty;
        if (userSelection == "1")
        {
            Console.WriteLine("Input amount of UAH to be converted: ");
            var value = double.Parse(Console.ReadLine() ?? string.Empty);
            Console.WriteLine($"{value} UAH is {conv.ConvertUahToUsd(value):0.##} USD");
        }
        else if (userSelection == "2")
        {
            Console.WriteLine("Input amount of USD to be converted: ");
            var value = double.Parse(Console.ReadLine() ?? string.Empty);
            Console.WriteLine($"{value} USD is {conv.ConvertUsdToUah(value):0.##} UAH");
        }
        else if (userSelection == "3")
        {
            Console.WriteLine("Input amount of UAH to be converted: ");
            var value = double.Parse(Console.ReadLine() ?? string.Empty);
            Console.WriteLine($"{value} UAH is {conv.ConvertUahToEur(value):0.##} EUR");
        }
        else if (userSelection == "4")
        {
            Console.WriteLine("Input amount of EUR to be converted: ");
            var value = double.Parse(Console.ReadLine() ?? string.Empty);
            Console.WriteLine($"{value} EUR is {conv.ConvertEurToUah(value):0.##} UAH");
        }
        else if (userSelection == "5")
        {
            Console.WriteLine("Input amount of UAH to be converted: ");
            var value = double.Parse(Console.ReadLine() ?? string.Empty);
            Console.WriteLine($"{value} UAH is {conv.ConvertUahToPln(value):0.##} PLN");
        }
        else if (userSelection == "6")
        {
            Console.WriteLine("Input amount of PLN to be converted: ");
            var value = double.Parse(Console.ReadLine() ?? string.Empty);
            Console.WriteLine($"{value} PLN is {conv.ConvertPlnToUah(value):0.##} UAH");
        }
        else
        {
            Console.WriteLine("Wrong currency pair selection.");
        }
    }

    public class Converter
    {
        private double _usd;
        private double _eur;
        private double _pln;

        public Converter(double usd, double eur, double pln)
        {
            _usd = usd;
            _eur = eur;
            _pln = pln;
        }

        public double ConvertUahToUsd(double uahValue)
        {
            return uahValue * _usd;
        }

        public double ConvertUsdToUah(double usdValue)
        {
            return usdValue / _usd;
        }

        public double ConvertUahToEur(double uahValue)
        {
            return uahValue * _eur;
        }

        public double ConvertEurToUah(double eurValue)
        {
            return eurValue / _eur;
        }

        public double ConvertUahToPln(double uahValue)
        {
            return uahValue * _pln;
        }

        public double ConvertPlnToUah(double plnValue)
        {
            return plnValue / _pln;
        }
    }
}*/
/*public class Program
{
    public static void Main()
    {
        var paymentsDict = new Dictionary<string, double>
                {
                    {"Director", 20000},
                    {"Manager", 10000},
                    {"Driver", 8000},
                    {"cleaner", 1000}
                };

        var fee = 0.1;

        var employee = new Employee("Vadym", "Kornelyuk")
        {
            Position = "Director",
            Experience = 3
        };
        Console.WriteLine(
            $"Oklad {employee.FirstName} {employee.LastName} on position {employee.Position} with experience {employee.Experience} is {employee.CalculateOklad(paymentsDict, fee)}");
    }

    public class Employee
    {
        private string _firstName;
        private string _lastName;
        private string _position;
        private int _experience;

        public Employee(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }

        public string Position
        {
            get => _position;
            set => _position = value;
        }

        public int Experience
        {
            get => _experience;
            set => _experience = value;
        }

        public string FirstName => _firstName;

        public string LastName => _lastName;

        public double CalculateOklad(Dictionary<string, double> paymentDictionary, double fee)
        {
            if (paymentDictionary.TryGetValue(Position, out var payment))
            {
                return payment * (1 + Experience * 0.1) * (1 - fee);
            }

            return 0;
        }
    }
}*/
public class Program
{
    public static void Main()
    {
        var user = new User("qwe", "Vadym", "Kornelyuk");
        Console.WriteLine($"Login: {user.Login}\nFirstName: {user.FirstName}\nLastName: {user.LastName}\nRegistrationTime: {user.RegistrationTime}\n");
    }

    public class User
    {
        private string _login;
        private string _firstName;
        private string _lastName;
        private readonly DateTime _registrationTime;

        public User(string login, string firstName, string lastName)
        {
            _login = login;
            _firstName = firstName;
            _lastName = lastName;
            _registrationTime = DateTime.Now;
        }

        public string Login
        {
            get => _login;
            set => _login = value;
        }

        public string FirstName
        {
            get => _firstName;
            set => _firstName = value;
        }

        public string LastName
        {
            get => _lastName;
            set => _lastName = value;
        }

        public DateTime RegistrationTime => _registrationTime;
    }
}

