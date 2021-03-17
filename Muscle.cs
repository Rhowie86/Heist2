using System;

namespace Heist2
{
    public class Muscle : IRobber
    {
        public string Name { get; set; } = "Dwayne 'The Rock' Johnson";

        public string Specialty { get; set; } = "Muscle";


        public int SkillLevel { get; set; } = 45;

        public int PercentageCut { get; set; } = 25;

        public void PerformSkill(Bank param)
        {
            param.AlarmScore = SkillLevel - param.AlarmScore;
            Console.WriteLine($"{Name} is picking the lock, decreased security {SkillLevel} points.");
            Console.WriteLine("");
            Console.WriteLine("---------------------");
            Console.WriteLine("");
            if (param.VaultScore <= 0)
            {
                Console.WriteLine($"{Name} has picked the lock on the vault door!");
            }

        }

    }

}