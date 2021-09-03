using Interfaces.Actions;
using Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Npcs
{
    public class NpcEnemy : Player, IEnemyActions
    {
        public NpcEnemy(string Id, string Name, byte[] Texture, byte Gender) 
            : base(Id, Name, Texture, Gender)
        {
        }

        public void AttackPlayer(Npc player) 
        {
            Console.WriteLine($"Npc {Name} is attacking player {player.Name}"); ;
        }

        public void AvoidAttack()
        {
            Console.WriteLine("Avoiding Attack, Whoosh!"); ;
        }

        public void ChasePlayer(Npc player)
        {
            Console.WriteLine($"Npc {Name} is chasing player {player.Name}"); ;
        }

        public void Dodge()
        {
            Console.WriteLine("Dodging incomming attack"); ;
        }
    }
}
