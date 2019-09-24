using Builder.Builder;
using Builder.ConcreteBuilder;
using Builder.Director;
using System;
using System.Collections.Generic;


/// <summary>
/// This code demonstrates the Builder pattern in which different cars 
/// are assembled in a step-by-step fashion. The CarFactory uses 
/// CarBuilders to construct a two types of cars in a series of 
/// sequential steps.
/// </summary>
namespace Builder
{
    class Program
    {
        /// <summary>
        /// The Client
        /// </summary>
        static void Main(string[] args)
        {
            var superBuilder = new SuperCarBuilder();
            var notSuperBuilder = new NotSoSuperCarBuilder();

            var factory = new Carfactory();
            var builders = new List <CarBuilder>
            {
                superBuilder,
                notSuperBuilder
            };
            foreach (var b in builders)
            {
                var c = factory.Build(b);
                Console.WriteLine($"The car requested by " +
                    $"{b.GetType().Name}: " +
                    $"\n-----------------------------------" +
                    $"\nDoors: {c.Doors}" +
                    $"\nSeats: {c.Seats}" +
                    $"\nHorse power: {c.HorsePower}" +
                    $"\nImpressive feature: {c.MostImpressiveFeature}" +
                    $"\nTop speed: {c.TopSpeedMPH} mph\n");
            }
        }
    }
}