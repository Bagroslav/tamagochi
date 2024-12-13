using System;
using tamagoči;
try
{
    var lizard = new Lizard();
    var who = lizard.WhoamI();
    Console.WriteLine(who);
    while (true)
    {
        var toss = lizard.Do();

        {
            Thread.Sleep(904);
            Console.WriteLine($"Toss was {toss}");

            if (toss > 0)

            {
                var action = Console.ReadLine();
                while (action != "exit")
                {
                    if (action == "jez")
                    {
                        lizard.Feed();
                        break;
                    }
                    if (action == "hraj si")
                    {
                        lizard.Play();
                        break;
                    }
                }
            }
        }

        Console.WriteLine(lizard.Hunger);
        Console.WriteLine(lizard.Boredom);
        Console.WriteLine(lizard.isAlive());
    }
}
catch (DeadPetException)
{
    Console.WriteLine("rip-bozo");
    Console.WriteLine("chcipak jeden");
}