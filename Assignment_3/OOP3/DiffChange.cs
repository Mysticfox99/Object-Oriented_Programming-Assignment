using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace OOP3
{
    class DiffChange
    {
        public static void Change(string[] user_input_array)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Trace.WriteLine($"[Files {user_input_array[1]} and {user_input_array[2]} are different]");
            Console.ForegroundColor = ConsoleColor.White;
            
            //Use the accessors from class Files
            Files f = new Files
            {
                File1 = File.ReadAllLines(user_input_array[1]), //Open selected file1
                File2 = File.ReadAllLines(user_input_array[2]) //Open selected file2
            };
            
            for (int i = 0; i < f.File1.Length; i++) 
            {

                if (f.File1[i] != f.File2[i])
                {
                    List<string> fileLine1 = f.File1[i].Split(' ').ToList();
                    List<string> fileLine2 = f.File2[i].Split(' ').ToList();
                    Trace.WriteLine("\n"); // Split up all changed lines

                    Console.ForegroundColor = ConsoleColor.Yellow; //Change text colour to yellow for the output box
                    Trace.Write("[Line " + (i + 1) + "] ");
                    Console.ForegroundColor = ConsoleColor.White;

                    for (int x = 0; x < fileLine1.Count; x++) //compare characters in string
                    {

                        //Print unchanged lines
                        if (fileLine1[x] == fileLine2[x])
                        {
                            Trace.Write($"{fileLine1[x]} ");
                        }
                        //Print changed word
                        else
                        {
                            if (fileLine2.Count > fileLine1.Count)
                            {
                                fileLine1.Insert(x, "");
                            }

                            else if (fileLine1.Count > fileLine2.Count)
                            {
                                fileLine2.Insert(x, "");
                            }
                            if (fileLine1[x] != fileLine2[x])
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Trace.Write($"{fileLine1[x]} ");
                                Console.ForegroundColor = ConsoleColor.White;

                            }
                            Console.ForegroundColor = ConsoleColor.Green;
                            Trace.Write($"{fileLine2[x]} ");
                            Console.ForegroundColor = ConsoleColor.White;

                        }
                    }
                }
            }
                                    
                              

            
        }


    }

}
    

