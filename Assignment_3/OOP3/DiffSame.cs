using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Diagnostics;


namespace OOP3
{
    class DiffSame
    {
        public static void Same(string[] user_input_array)
        {
            Console.ForegroundColor = ConsoleColor.Green; //Change text colour to green for the output box
            Trace.Write("[Output]: ");
            Console.ForegroundColor = ConsoleColor.White; //Change the text colour to white for the rest of the text
            Trace.WriteLine($"Files {user_input_array[1]} and {user_input_array[2]} are the same");           
        }

    }


}

