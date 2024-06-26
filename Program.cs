using System.Net;
using System.Numerics;

namespace Csharp_DZ_5_Dedok
{
    //для задания 1
    struct Client
    {
        public int ClientCode { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public int OrderCount { get; set; }
        public decimal TotalOrderAmount { get; set; }
        public string Importance { get; set; }
        public Client(int clientCode, string fullName, string address, string phone, int orderCount, decimal totalOrderAmount, string importance)
        {
            ClientCode = clientCode;
            FullName = fullName;
            Address = address;
            Phone = phone;
            OrderCount = orderCount;
            TotalOrderAmount = totalOrderAmount;
            Importance = importance;
        }
        public void Print()
        {
            Console.WriteLine($"Client Code: {ClientCode}");
            Console.WriteLine($"Full Name: {FullName}");
            Console.WriteLine($"Address: {Address}");
            Console.WriteLine($"Phone: {Phone}");
            Console.WriteLine($"Order Count: {OrderCount}");
            Console.WriteLine($"Total Order Amount: {TotalOrderAmount}");
            Console.WriteLine($"Importance: {Importance}");
        }
    }
    //для задания 3
    class Plane
    {
        private string name;
        private string manufacturer;
        private int yearOfManufacture;
        private string type;
        public Plane()
        {
            name = "";
            manufacturer = "";
            yearOfManufacture = 0;
            type = "";
        }
        public Plane(string name, string manufacturer, int yearOfManufacture, string type)
        {
            this.name = name;
            this.manufacturer = manufacturer;
            this.yearOfManufacture = yearOfManufacture;
            this.type = type;
        }
        public void InputData()
        {
            Console.WriteLine("Enter the plane's name:");
            name = Console.ReadLine();
            Console.WriteLine("Enter the manufacturer's name:");
            manufacturer = Console.ReadLine();
            Console.WriteLine("Enter the year of manufacture:");
            yearOfManufacture = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the type of plane:");
            type = Console.ReadLine();
        }
        public void PrintData()
        {
            Console.WriteLine($"Plane Name: {name}");
            Console.WriteLine($"Manufacturer: {manufacturer}");
            Console.WriteLine($"Year of Manufacture: {yearOfManufacture}");
            Console.WriteLine($"Plane Type: {type}");
        }
        public string GetName()
        {
            return name;
        }
        public void SetName(string value)
        {
            name = value;
        }
        public string GetManufacturer()
        {
            return manufacturer;
        }
        public void SetManufacturer(string value)
        {
            manufacturer = value;
        }
        public int GetYearOfManufacture()
        {
            return yearOfManufacture;
        }
        public void SetYearOfManufacture(int value)
        {
            yearOfManufacture = value;
        }
        public string GetType()
        {
            return type;
        }
        public void SetType(string value)
        {
            type = value;
        }
    }
    //для задания 4
    class Journal
    {
        private string name;
        private int foundingYear;
        private string description;
        private string contactPhone;
        private string contactEmail;
        public Journal()
        {
            name = "";
            foundingYear = 0;
            description = "";
            contactPhone = "";
            contactEmail = "";
        }
        public Journal(string name, int foundingYear, string description, string contactPhone, string contactEmail)
        {
            this.name = name;
            this.foundingYear = foundingYear;
            this.description = description;
            this.contactPhone = contactPhone;
            this.contactEmail = contactEmail;
        }
        public void InputData()
        {
            Console.WriteLine("Enter the journal's name:");
            name = Console.ReadLine();

            Console.WriteLine("Enter the founding year:");
            foundingYear = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the description of the journal:");
            description = Console.ReadLine();

            Console.WriteLine("Enter the contact phone number:");
            contactPhone = Console.ReadLine();

            Console.WriteLine("Enter the contact email:");
            contactEmail = Console.ReadLine();
        }
        public void PrintData()
        {
            Console.WriteLine($"Journal Name: {name}");
            Console.WriteLine($"Founding Year: {foundingYear}");
            Console.WriteLine($"Description: {description}");
            Console.WriteLine($"Contact Phone: {contactPhone}");
            Console.WriteLine($"Contact Email: {contactEmail}");
        }
        public string GetName()
        {
            return name;
        }
        public void SetName(string value)
        {
            name = value;
        }
        public int GetFoundingYear()
        {
            return foundingYear;
        }
        public void SetFoundingYear(int value)
        {
            foundingYear = value;
        }
        public string GetDescription()
        {
            return description;
        }
        public void SetDescription(string value)
        {
            description = value;
        }
        public string GetContactPhone()
        {
            return contactPhone;
        }
        public void SetContactPhone(string value)
        {
            contactPhone = value;
        }
        public string GetContactEmail()
        {
            return contactEmail;
        }
        public void SetContactEmail(string value)
        {
            contactEmail = value;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Task_1
            Client client = new Client(
            clientCode: 123,
            fullName: "Ivan Ivanov",
            address: "123 Main St, Kiev",
            phone: "+38-068-456-7890",
            orderCount: 10,
            totalOrderAmount: 15000.50m,
            importance: "VIP"
        );
            client.Print();

            //Task_2 
            int start = 1;
            int end = 5;
            int sum = SumInRange(start, end);
            Console.WriteLine($"Сумма чисел от {start} до {end} равна {sum}");

            static int SumInRange(int start, int end)
            {
                if (start > end)
                {
                    throw new ArgumentException("Start value must be less than or equal to end value.");
                }

                int sum = 0;
                for (int i = start; i <= end; i++)
                {
                    sum += i;
                }
                return sum; 
            }
            //Task_3
            Plane plane = new Plane();
            plane.InputData();
            Console.WriteLine("\nPlane Details:");
            plane.PrintData();
            Console.WriteLine($"\nPlane Name: {plane.GetName()}");
            Console.WriteLine($"Year of Manufacture: {plane.GetYearOfManufacture()}");

            //Task_4
            Journal journal = new Journal();
            journal.InputData();
            Console.WriteLine("\nJournal Details:");
            journal.PrintData();
            Console.WriteLine($"\nJournal Name: {journal.GetName()}");
            Console.WriteLine($"Founding Year: {journal.GetFoundingYear()}");
        }
    }
}
