// See https://aka.ms/new-console-template for more information
namespace Variables;
public class Program
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
}

