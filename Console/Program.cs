using Business.Concrete;
using DataAccess.Concrete.InMemory;

namespace Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            foreach (var item in carManager.GetAll())

            {
                System.Console.WriteLine(item.Description);
            }
        }
    }
}