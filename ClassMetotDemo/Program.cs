namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer()
            {
                Id = 1,
                FirstName="Rabia",
                LastName="Kandemir",
                Address="Gaziosmanpaşa mahallesi"
            };
            Customer customer2 = new Customer()
            {
                Id = 2,
                FirstName = "Engin",
                LastName = "Demiroğ",
                Address = "Çankaya mahallesi"
            };
            Customer[] customers = new Customer[] { customer,customer2 };
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer);
            customerManager.Add(customer2);
            Console.WriteLine();
            customerManager.Delete(customer);
            customerManager.Delete(customer2);
            Console.WriteLine();
            customerManager.GetList(customers);
        }
    }
}