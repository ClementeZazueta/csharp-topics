using Interfaces.Actions;
using Interfaces.Models;
using System;

namespace Interfaces.Npcs
{
    public class Npc : Player, INeutralActions
    {

        public Npc(string Id, string Name, byte[] Texture, byte Gender) 
            : base(Id, Name, Texture, Gender)
        {
        }

        public void RunFromAttacker()
        {
            Console.WriteLine($"Player {Name} is running from attacker");
        }

        public void RunFromBattle()
        {
            Console.WriteLine($"Player {Name} is avoiding getting killed or harmed");
        }

        public void WalkingThroughMap()
        {
            Console.WriteLine($"Player {Name} is just waking by!");
        }

        public void InteractWithOtherPlayer(Npc player)
        {
            Console.WriteLine($"Interacting with npc {player.Name}");
        }

        public void TradetWithOtherPlayer(Npc player)
        {
            Console.WriteLine($"Trading items with npc {player.Name}");
        }

        public override void Jump()
        {
            Console.WriteLine("This is a virtual jump method, we can override it from our abstract class, only if this is override, abstract or virtual");
            Console.WriteLine($"{Name}: Hey! I have my own way to jump. Wohoo!");
        }
    }
}
