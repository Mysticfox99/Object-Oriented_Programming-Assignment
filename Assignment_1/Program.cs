using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace eu_voting
{
    class Program
    {
        static void QualifiedMajority(int yes, double pop_yes)
        {/*The code below creates the rules for voting qualified majority, which will determine the final result*/
            Console.WriteLine("\nFinal result");
            if (yes >= 15 & pop_yes >= 65)
            {
                Console.WriteLine("Approved");
            }
            else
            {
                Console.WriteLine("Rejected");
            }

        }
        static void Unanimity(int yes, double pop_yes)
        {/*The code below creates the unanimity voting rule, which also determines the final result*/
            Console.WriteLine("\nFinal result");
            if (yes == 27 & pop_yes == 100)
            {
                Console.WriteLine("Approved");
            }
            else
            {
                Console.WriteLine("Rejected");
            }
        }
        static void ReinforcedMajority(int yes, double pop_yes)
        {/*The reinforced majority is created here, which affects the final outputed result.*/
            Console.WriteLine("\nFinal result");
            if (yes >= 20 & pop_yes >= 65)
            {
                Console.WriteLine("Approved");
            }
            else
            {
                Console.WriteLine("Rejected");
            }
        }
        static void SimpleMajority(int yes)
        {/*Finally, the simple majority voting rule is created here which can also impact the final result if the terms are met.*/
            Console.WriteLine("\nFinal result");
            if (yes >= 14)
            {
                Console.WriteLine("Approved");
            }
            else
            {
                Console.WriteLine("Rejected");
            }
        }
        static void Main(string[] args)
        {
            Countries country = new Countries();

            /*The code below implements voting rules option, which allows the user to chose which rules they want to follow.*/
            Console.WriteLine("Set the voting rule: Qualified Majority (qm), Reinforced Qualified Majority (rq), Simple Majoirty (sm) or Unanimity (u)");
            string rule = Console.ReadLine();
            if (rule == "qm" | rule == "Qm" | rule == "QM" | rule == "qM")
            {
                Console.WriteLine("The rule you chose was Qualified Majority");
            }
            else if (rule == "u" | rule == "U")
            {
                Console.WriteLine("The rule you chose was Unanimity");
            }
            else if (rule == "rq" | rule == "RQ" | rule == "rQ" | rule == "Rq")
            {
                Console.WriteLine("The rule you chose was Reinforced Qualified Majority");
            }
            else if (rule == "sm"| rule == "SM" | rule == "Sm" | rule == "sM")
            {
                Console.WriteLine("The rule you chose was Simple Majority");
            }
            else
            {
                Console.WriteLine("Rule not recognised \nSet to Qualified Majority");
            }


            /*This code below adds validation for user input for rules.*/
            country.CountryDict();


            if (rule == "qm" | rule == "QM" | rule == "qM" | rule == "Qm")
            {
                QualifiedMajority(country.yes, country.pop_yes);

            }
            else if (rule == "u" | rule == "U")
            {
                Unanimity(country.yes, country.pop_yes);

            }
            else if (rule == "SM" | rule == "Sm" | rule == "sm" | rule == "sM")
            {
                SimpleMajority(country.yes);
            }
            else if (rule == "rq" | rule == "RQ" | rule == "rQ" | rule == "Rq")
            {
                ReinforcedMajority(country.yes, country.pop_yes);
            }
            else
            {
                QualifiedMajority(country.yes, country.pop_yes);
            }


            if (country.pop_yes < 0)
            {
                country.pop_yes = 0;
            }
            if (country.pop_no > 100)
            {
                country.pop_no = 100;
            }
            if (country.pop_abst > 100)
            {
                country.pop_abst = 100;
            }

            
            Console.WriteLine("");
            Console.WriteLine("Member States");
            Console.WriteLine($"{country.yes} countries voted yes");
            Console.WriteLine($"{country.no} countries voted no");
            Console.WriteLine($"{country.abst} countries voted abstain");
            Console.WriteLine("");
            Console.WriteLine("Population");
            Console.WriteLine($"{country.pop_yes}% voted yes");
            Console.WriteLine($"{country.pop_no}% voted no");
            Console.WriteLine($"{country.pop_abst}% voted abstain");
            
        }
    }/*Project by: Lucy West, Callum Cathrine, Ernestas Milinskas, and Isobel Carroll*/
}
