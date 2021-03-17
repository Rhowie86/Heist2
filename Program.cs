using System;
using System.Collections.Generic;

namespace Heist2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IRobber> rolodex = new List<IRobber>();

            Hacker keanu = new Hacker()
            {
                Name = "Keanu",
                SkillLevel = 30,
                PercentageCut = 25,
            };

            Hacker crash = new Hacker()
            {
                Name = "CrashOverride",
                SkillLevel = 80,
                PercentageCut = 25,
            };

            Muscle vin = new Muscle()
            {
                Name = "Vin Diesl",
                SkillLevel = 60,
                PercentageCut = 25
            };

            Muscle biden = new Muscle()
            {
                Name = "Joe Biden",
                SkillLevel = 95,
                PercentageCut = 75
            };

            LockSpecialist chairman = new LockSpecialist()
            {
                Name = "Chairman Meow",
                SkillLevel = 99,
                PercentageCut = 99
            };

            LockSpecialist jeff = new LockSpecialist()
            {
                Name = "Jeff Gerstman",
                SkillLevel = 45,
                PercentageCut = 25
            };

            rolodex.Add(keanu);
            rolodex.Add(crash);
            rolodex.Add(vin);
            rolodex.Add(biden);
            rolodex.Add(chairman);
            rolodex.Add(jeff);

            Console.WriteLine($"Your rolodex currently contains {rolodex.Count} entries.");
            Console.WriteLine("");
            Console.Write("What is the name of the operative you would like to add? >>");
            string name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("Select one of these specialties.");
            Console.WriteLine("");
            Console.WriteLine(@"
                1) Hacker (disable alarms)
                2) Muscle (disarm guards)
                3) Lock Specialist (cracks lock)
            ");
            int specialty = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("");
            Console.Write("What is their skill level? >>");
            int skill = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("");
            Console.Write("What is their demand for their cut? >>");
            int cut = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            if (specialty == 1)
            {
                rolodex.Add(new Hacker()
                {
                    Name = name,
                    SkillLevel = skill,
                    PercentageCut = cut

                });
            }
            else if (specialty == 2)
            {
                rolodex.Add(new Muscle()
                {
                    Name = name,
                    SkillLevel = skill,
                    PercentageCut = cut
                });
            }
            else if (specialty == 3)
                {
                    {
                        rolodex.Add(new LockSpecialist()
                        {
                            Name = name,
                            SkillLevel = skill,
                            PercentageCut = cut
                        });
                    }
                }



            Bank newBank = new Bank()
            {
                AlarmScore = new Random().Next(100),
                VaultScore = new Random().Next(100),
                SecurityGuardScore = new Random().Next(100),
                CashOnHand = new Random().Next(50000, 1000000)
            };
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("----------");
            Console.WriteLine("");
            Console.WriteLine("Here is your recon report");
            Console.WriteLine("");

            if (newBank.AlarmScore > newBank.VaultScore && newBank.AlarmScore > newBank.SecurityGuardScore)
            {
                Console.WriteLine("Most Secure: Alarms");
            }
            else if (newBank.VaultScore > newBank.AlarmScore && newBank.VaultScore > newBank.SecurityGuardScore)
            {
                Console.WriteLine("Most Secure: Vault");
            }
            else if (newBank.SecurityGuardScore > newBank.AlarmScore && newBank.SecurityGuardScore > newBank.VaultScore)
            {
                Console.WriteLine("Most Secure: Security Guards");
            }

            if (newBank.AlarmScore < newBank.VaultScore && newBank.AlarmScore < newBank.SecurityGuardScore)
            {
                Console.WriteLine("Least Secure : Alarms");
            }
            else if (newBank.VaultScore < newBank.AlarmScore && newBank.VaultScore < newBank.SecurityGuardScore)
            {
                Console.WriteLine("Least Secure : Vault");
            }
            else if (newBank.SecurityGuardScore < newBank.AlarmScore && newBank.SecurityGuardScore < newBank.VaultScore)
            {
                Console.WriteLine("Least Secure : Security Guards");
            }

            Console.WriteLine("");
            Console.WriteLine("------------------");
            Console.WriteLine("");

        int index = 0;
        foreach (IRobber operative in rolodex)
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine($"Operative Designation {index}");
            Console.WriteLine($"Name: {operative.Name}");
            Console.WriteLine("--");
            Console.WriteLine($"Specialty: {operative.Specialty}");
            Console.WriteLine("--");
            Console.WriteLine($"Skill Level: {operative.SkillLevel}");
            Console.WriteLine("--");
            Console.WriteLine($"Their cut: {operative.PercentageCut} %");
            Console.WriteLine($"");
            Console.WriteLine("--------------------------------");
            index ++;
        }


        List<IRobber> crew = new List<IRobber>();

        Console.WriteLine("");
        Console.Write("Select your operatives by their Designation number. >> ");
        int selection = int.Parse(Console.ReadLine());
        
         crew.Add(rolodex[selection]);

         Console.WriteLine("-------------------------------------------------");
         Console.WriteLine($@"
         crew members
          ");





        }



    }
}

