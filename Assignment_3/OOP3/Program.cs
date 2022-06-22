using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*diff GitRepositories_1a.txt GitRepositories_1b.txt
            diff GitRepositories_2a.txt GitRepositories_2b.txt
            diff GitRepositories_3a.txt GitRepositories_3b.txt */

            //Access the log class to print the program and create log file
            LogFile.Log();
            
            //Access the user input class so user can enter the files they want
            UserInput.Input(args);

        }
    }
}
