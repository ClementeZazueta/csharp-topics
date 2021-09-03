using GenericsClasses;
using Interfaces.Models;
using Interfaces.Npcs;
using System;
using System.Collections.Generic;
using ExtensionMethods;
using AsyncAwaitDemo;
using System.Threading.Tasks;

namespace CSharpTopics
{
    class Program
    {
        static void Main(string[] args)
        {

            var excercises = new Excercises();

            excercises.Interfaces();
            excercises.AbstractClasses();
            excercises.Generics();
            excercises.AsyncAwaitTask();
            excercises.ExtensionMethods();
            excercises.GenericsDelegates();
            excercises.AnonymousTypes();
            
            Console.ReadKey();
        }
    }
}
