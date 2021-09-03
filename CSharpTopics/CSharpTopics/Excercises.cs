using AsyncAwaitDemo;
using ExtensionMethods;
using GenericsClasses;
using Interfaces.Npcs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTopics
{
    public class Excercises
    {
        public void Interfaces()
        {
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
        }

        public void AbstractClasses()
        {
            byte[] texture = { 0x20, 0x20, 0x20, 0x20, 0x20, 0x20 };

            Npc npc = new Npc(Guid.NewGuid().ToString(), "Peter", texture, 1);
            NpcEnemy npcEnemy = new NpcEnemy(Guid.NewGuid().ToString(), "Thief 1", texture, 1);

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
        }

        public void Generics()
        {
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

            var result2 = new OperationResult<Vehicle>();
            var vehicle = new Vehicle("Jeep", "Renegade");
            Console.WriteLine(result2.Ok(vehicle));

            Console.WriteLine("");
        }

        public void AsyncAwaitTask()
        {
            var defaultColor = Console.ForegroundColor;
            Console.WriteLine("------------------------");
            Console.WriteLine("Async Await Task");
            Console.WriteLine("------------------------");
            Console.WriteLine("Used for doing asynchronus tasks to make possible the fact of doing other tasks meanwhile this is being executed");
            Console.WriteLine("This action will get the result of an API call, at the end");
            Console.WriteLine("An async method requires a Task to return or void, in case that you want to return another data type you must use generics Task<T>");
            Console.WriteLine("This is executed in the Threading Pool (in another thread)");
            Console.WriteLine("------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Starting to fetch api");
            Console.ForegroundColor = defaultColor;

            ApiCall asyncAwait = new();

            Action AwaitableFunction = async () =>
            {
                await asyncAwait.CallingStartwarsApi();
            };

            AwaitableFunction();

            Console.WriteLine("");
        }

        public void ExtensionMethods()
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("Extension Methods");
            Console.WriteLine("------------------------");
            Console.WriteLine("Use for \"Extend\" an exsiting class like string class or SimpleLogger (custom class of my own)");
            Console.WriteLine("------------------------");

            //Just added a new method to the exsiting class string
            string demo = "demo";
            demo.PrintToConsole();

            SimpleLogger simpleLogger = new();

            simpleLogger.Log("A message in the log");
            simpleLogger.LogError("An error message to de log.");

            Console.WriteLine("");
        }

        public void GenericsDelegates()
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("Generics delegates");
            Console.WriteLine("------------------------");
            Console.WriteLine("Used for store functions un variables, like an arrow function");
            Console.WriteLine("Action, can take 6 paramters and doesn't return a value (a void arrow function)");
            Console.WriteLine("------------------------");

            Action<string> PrintResult = (result) => Console.WriteLine($"PrintResult() => The result is {result}");
            PrintResult("Some result");

            Console.WriteLine("------------------------");
            Console.WriteLine("Func, can take 6 paramters and return a value (a return arrow function)");
            Console.WriteLine("Func<param1, param2..., param6, returnValue>");
            Console.WriteLine("------------------------");

            Func<double, double, double, double> VolumeOfCube = (x, y, z) => (x * y * z);
            var volume = VolumeOfCube(3, 3, 3);

            Console.Write("volumeOfCube(3, 3, 3) => ");
            PrintResult(volume.ToString());

            Console.WriteLine("------------------------");
            Console.WriteLine("Predicate, can take 1 paramter and return a boolean value (a return arrow function)");
            Console.WriteLine("------------------------");

            Predicate<double> IsVolumeGraterThanZero = (volume) => volume > 0;

            PrintResult(IsVolumeGraterThanZero(volume).ToString());

            Console.WriteLine("");
        }

        public void AnonymousTypes()
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("Anonymous Types");
            Console.WriteLine("------------------------");
            Console.WriteLine("Used for store inmmutable data with no need of specifying a class, can store an instance class but no necessarily");
            Console.WriteLine("Can't mutate an anonymous type that store a class either");
            Console.WriteLine("------------------------");

            var Instance = new
            {
                Name = "Carlos",
                LastName = "Zazueta",
                Job = ".NET Full Stack developer in progress",
                Age = 23,
                BirthDate = Convert.ToDateTime("1998/04/30")
            };

            //TODO:Try to change the value of a property or uncomment the next line to see the error
            //Instance.Name = "Clemente";

            Console.WriteLine(Instance.ToString());
        }
    }
}
