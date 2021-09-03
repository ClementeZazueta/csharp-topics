using GenericsClasses;
using Interfaces.Models;
using Interfaces.Npcs;
using System;
using System.Collections.Generic;
using ExtensionMethods;
using AsyncAwaitDemo;

namespace CSharpTopics
{
    class Program
    {
        static void Main(string[] args)
        {
            var defaulColor = Console.ForegroundColor;
            byte[] texture = { 0x20, 0x20, 0x20, 0x20, 0x20, 0x20 };

            Npc npc = new Npc(Guid.NewGuid().ToString(), "Peter", texture, 1);
            Npc npc2 = new Npc(Guid.NewGuid().ToString(), "Jhon", texture, 1);
            NpcEnemy npcEnemy = new NpcEnemy(Guid.NewGuid().ToString(), "Thief 1", texture, 1);

            Console.WriteLine("POC C# Topics");
            Console.WriteLine("------------------------");
            Console.WriteLine("Interfaces");
            Console.WriteLine("------------------------");

            Console.WriteLine($"Hi {npc2.Name} my name is: { npc.Name }");
            npc.InteractWithOtherPlayer(npc2);
            npc2.TradetWithOtherPlayer(npc);
            npc.WalkingThroughMap();
            npc2.WalkingThroughMap();

            npcEnemy.AttackPlayer(npc);
            npc.RunFromAttacker();
            npc2.RunFromBattle();
            npcEnemy.ChasePlayer(npc);

            Console.WriteLine("");

            Console.WriteLine("------------------------");
            Console.WriteLine("Abstract classes");
            Console.WriteLine("------------------------");
            Console.WriteLine("Used to prevent others to make instances of this class, used in inheritance to just inherit as its name says.");
            Console.WriteLine("This type of class that is actually a class, differs from a interface, the reason is that an interface is just a ");
            Console.WriteLine("boiler plate of your methods, only firms og the methods can be written there but in abstract classes you can write a");
            Console.WriteLine("normal class with methods and properties like always but you won't be able to make instances of it.");
            Console.WriteLine("Try to make an instance with the next commented line of code.");
            Console.WriteLine("------------------------");

            //TODO:Uncomment this line to see the actual error
            //Player player = new Player(Guid.NewGuid().ToString(), "Peter", texture, 1);
            npc.Jump();
            npcEnemy.Jump();

            Console.WriteLine("");
            Console.WriteLine("------------------------");
            Console.WriteLine("Generics");
            Console.WriteLine("------------------------");

            Console.WriteLine("Generics are a used to generate function, properties or classes with any type of data-type");
            Console.WriteLine("You can use it in a custom class\n");
            var result = new OperationResult<Person>();
            var person = new Person("Carlos", "Zazueta");
            result.AddMessage("An error has happened");
            result.SetStatusCode(500, person);

            Console.WriteLine("");

            Console.WriteLine("");
            Console.WriteLine("------------------------");
            Console.WriteLine("Async Await");
            Console.WriteLine("Used for doing asynchronus tasks to make possible the fact of doing other tasks meanwhile this is being executed");
            Console.WriteLine("This action will get the result of an API call, at the end");
            Console.WriteLine("An async method requires a Task to return or void, in case that you want to return another data type you must use generics Task<T>");
            Console.WriteLine("This is executed in the Threading Pool (in another thread)");
            Console.WriteLine("------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Starting to fetch api");
            Console.ForegroundColor = defaulColor;

            ApiCall asyncAwait = new();
            asyncAwait.CallingStartwarsApi();

            var result2 = new OperationResult<Vehicle>();
            var vehicle = new Vehicle("Jeep", "Renegade");
            Console.WriteLine(result2.Ok(vehicle));

            Console.WriteLine("");
            Console.WriteLine("------------------------");
            Console.WriteLine("Extension Methods");
            Console.WriteLine("Use for \"Extend\" an exsiting class like string class or SimpleLogger (custom class of my own)");
            Console.WriteLine("------------------------");

            //Just added a new method to the exsiting class string
            string demo = "demo";
            demo.PrintToConsole();

            SimpleLogger simpleLogger = new();

            simpleLogger.Log("A message in the log");
            simpleLogger.LogError("An error message to de log.");

            Console.ReadKey();
        }
    }
}
