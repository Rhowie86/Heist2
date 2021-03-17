using System;

namespace Heist2
{
    public class Hacker : IRobber
    {
        public string Name { get; set; } = "Neo";

        public string Specialty { get; set; } = "Hacker";

        public int SkillLevel { get; set; } = 80;

        public int PercentageCut { get; set; } = 25;

        public void PerformSkill(Bank param)
        {
            param.AlarmScore = SkillLevel - param.AlarmScore;
            Console.WriteLine($"{Name} is hacking the alarm system, decreased security {SkillLevel} points.");
            Console.WriteLine("");
            Console.WriteLine("---------------------");
            Console.WriteLine("");
            if (param.VaultScore <= 0)
            {
                Console.WriteLine($"{Name} has taken down the alarm system!");
            }

        }

    }

}