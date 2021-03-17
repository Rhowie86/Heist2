using System;

namespace Heist2
{
    public class LockSpecialist : IRobber
    {
        public string Name { get; set; } = "Owen Wilson";

        public string Specialty { get; set; } = "Lock Specialist";


        public int SkillLevel { get; set; } = 10;

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