using EFCore.Data.Context;

namespace EFCore
{
    internal class Program
    {
        static void Main()
        {
            using MyCompanyDbContext dbContext = new MyCompanyDbContext();
        }
    }
}
