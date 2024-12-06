using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace tamagoči
{
    public abstract class Pet
    {
        //public int Hunger {get private set;} = 50;
        private int hunger = 50;
        public int Hunger
        {
            get
            {
                return hunger;
            }
            set
            {
                hunger = value;
                if (!isAlive())

                {
                    throw new DeadPetException();
                }
            }
        }
        private Random random = new Random();
        public int Boredom { get; private set; } = 50;
        public void Feed()
        {
            Hunger -= 30;
            Boredom += 15;
            Console.WriteLine("Feeding");
        }
        public void Play()
        {
            Hunger += 30;
            Boredom -= 15;
            Console.WriteLine("Playing");
        }
        public void Chill()
        {
            Hunger += 10;
            Boredom += 10;
            Console.WriteLine("Chillin...");
        }
        public int Do()
        {
            var toss = random.Next(1, 20);
            Console.WriteLine(toss);
            if (toss < 10)
            {
                Chill();
            }
            else if (toss < 16)
            {
                Play();
            }
            else
            {
                Feed();
            }
            return toss;

        }


        
        public bool isAlive()
        {
            if (Hunger > 100 || Hunger < 0)
            {
                return false;
            }

            return true;
        }
        
        public virtual string WhoamI()
        {
            return "pet";
        }
    }
}
