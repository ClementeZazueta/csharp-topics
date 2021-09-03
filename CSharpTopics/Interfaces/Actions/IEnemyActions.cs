using Interfaces.Models;
using Interfaces.Npcs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Actions
{
    public interface IEnemyActions
    {
        void AttackPlayer(Npc player);
        void AvoidAttack();
        void ChasePlayer(Npc player);
        void Dodge();
    }
}
