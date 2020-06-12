using ConsoleApp.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            OnlyAsNoTracking();
            WithPerformIdentityResolution();
        }

        private static void OnlyAsNoTracking()
        {
            using var db = new SampleAppContext();
            var itens1 = db
                .OrderItems
                .AsNoTracking()
                .Include(p => p.Order)
                .Where(p => p.OrderId == 1)

            .ToList();
        }

        private static void WithPerformIdentityResolution()
        {
            using var db = new SampleAppContext();
            var itens2 = db
                .OrderItems
                .AsNoTracking()
                .PerformIdentityResolution()
                .Include(p => p.Order)
                .Where(p => p.OrderId == 1)

            .ToList();
        }
    }
}
