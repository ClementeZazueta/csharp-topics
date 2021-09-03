using Interfaces.Npcs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Actions
{
    public interface INeutralActions
    {
        void RunFromBattle();
        void RunFromAttacker();
        void WalkingThroughMap();
        void InteractWithOtherPlayer(Npc player);
        void TradetWithOtherPlayer(Npc player);
    }
}
