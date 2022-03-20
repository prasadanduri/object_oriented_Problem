using System;

namespace InventoryDataManagement
{

    class Program
    {
        static void Main(string[] args)
        {
            string path = C:\Users\Prasad\source\repos\InventoryDataManagement\InventoryDataManagement\Rice.json;

            FetchDataForRice fetchDataForRice = new FetchDataForRice();
            Rice data = fetchDataForRice.Read(path);

            Console.WriteLine(data.Name);
            Console.WriteLine(data.Weight);
            Console.WriteLine(data.Price);


        }
    }
}