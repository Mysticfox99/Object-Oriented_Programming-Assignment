using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace eu_voting

{
	class Countries
    {
        public int yes = 27;
        public int no = 0;
        public int abst = 0;

        public double pop_yes = 100.00;
        public double pop_no = 0.00;
        public double pop_abst = 0.00;


        private static Dictionary<string, double> CountryList = new Dictionary<string, double>
            {
            /*This is a Dictionary of all the countries, and the percentage of their vote. This affects how the overall results will be outputed.*/
                { "Austria", 1.98 },
                { "Belgium", 2.56 },
                { "Bulgaria", 1.56 },
                { "Croatia", 0.91 },
                { "Cyprus", 0.20 },
                { "Czech Republic", 2.35 },
                { "Denmark", 1.30 },
                { "Estonia", 0.30 },
                { "Finland", 1.23 },
                { "France", 14.98 },
                { "Germany", 18.54 },
                { "Greece", 2.40 },
                { "Hungary", 2.18 },
                { "Ireland", 1.10 },
                { "Italy", 13.65 },
                { "Latvia", 0.43 },
                { "Lithuania", 0.62 },
                { "Luxembourg", 0.14 },
                { "Malta", 0.11 },
                { "Netherlands", 3.89 },
                { "Poland", 8.49 },
                { "Portugal", 2.30 },
                { "Romania", 4.34 },
                { "Slovakia", 1.22 },
                { "Slovenia", 0.47 },
                { "Spain", 10.49 },
                { "Sweden", 2.29 },
            };
        private void _setVotes()
        {/*This code tells the user how they show votes using the y, n, and a key*/ 
            Console.WriteLine("\nSet the votes for each country (y/n/a)");
        }

        private void _votePercentage()
        {/*Here, the voting rules on how the inputed decisions will affect the results.*/
            foreach (var c in CountryList)
            {
                bool check = true;
                while (check)
                {
                    Console.Write($"{c.Key}: ");
                    string vote = Console.ReadLine();
                    vote = Regex.Replace(vote, @"\s", "");
                    if (vote == "y" | vote == "Y")
                    {
                        Console.WriteLine($"{c.Key} voted yes\n");
                        check = false;
                    }
                    else if (vote == "n" | vote == "N")
                    {
                        no++;
                        yes--;
                        pop_no = Math.Round(pop_no + c.Value, 2);
                        pop_yes = Math.Round(pop_yes - c.Value, 2);
                        Console.WriteLine($"{c.Key} voted no\n");
                        check = false;
                    }
                    else if (vote == "a" | vote == "A")
                    {
                        abst++;
                        yes--;
                        pop_abst = Math.Round(pop_abst + c.Value, 2);
                        pop_yes = Math.Round(pop_yes - c.Value, 2);
                        Console.WriteLine($"{c.Key} abstained from voting\n");
                        check = false;
                    }
                    else
                    {
                        Console.WriteLine("Please try again: ");
                        
                    }
                }
            }
        }

        public void CountryDict()
        {/*This uses a public method to call private methods, which restricts access for users*/
            _setVotes();
            _votePercentage();
            
        }
    }
}
