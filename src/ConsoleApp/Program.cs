using ConsoleApp.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using var db = new SampleAppContext();
            var orders = db
                    .Orders
                    .Include("OrderItems")

                .ToList();
        }
    }
}
