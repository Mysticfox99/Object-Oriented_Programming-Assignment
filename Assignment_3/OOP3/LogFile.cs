using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace OOP3
{
    class LogFile
    {
        public static void Log()
        {         
            DateTime now = DateTime.Now; //Get the current time & date
            var textfile = new TextWriterTraceListener("log.txt"); // Create a log file      
            var console = new ConsoleTraceListener(false); //tracing output to console
            Trace.Listeners.Add(textfile); //Add to the file
            Trace.WriteLine("\n");
            Trace.WriteLine(now); //Add the time & date to text file
            Trace.Listeners.Add(console); //Display console
            Trace.AutoFlush = true; //Get or Set flush to listeners
        }
    }
}
