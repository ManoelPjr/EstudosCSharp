using DemoConsole.Entities;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace DemoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            
            using (var db = new ActorDbContext())
            {
                var sp = db.GetInfrastructure<IServiceProvider>();
                var mapper = sp.GetService<IRelationalTypeMappingSource>();

                Console.WriteLine($"Type mapper in use: {mapper.GetType().Name} ");
                Console.WriteLine($"Mapping for bool: { mapper.GetMapping(typeof(bool)).StoreType}");
                Console.WriteLine($"Mapping for string:{ mapper.GetMapping(typeof(string)).StoreType}");

                Console.ReadLine();
            }
        }
    }
}
