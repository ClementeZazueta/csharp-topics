using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Models
{
    public abstract class Player
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public byte[] Texture { get; set; }
        public byte Gender { get; set; }

        public Player(string Id, string Name, byte[] Texture, byte Gender)
        {
            this.Id = Id;
            this.Name = Name;
            this.Texture = Texture;
            this.Gender = Gender;
        }

        public void Walk()
        {
            Console.WriteLine("I'm walking");
        }

        public void Run()
        {
            Console.WriteLine("I'm Running");
        }

        public virtual void Jump()
        {
            Console.WriteLine($"{Name}: I'm Jumping");
        }

        public void Speak()
        {
            Console.WriteLine("I'm Speaking and making some interactions to not look like a dead character!");
        }
    }
}
