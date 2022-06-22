using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace OOP3
{
    class UserInput
    {
        
        
        public static void Input(string[] args)
        {
            //Create an empty string array called user_input_array
            string[] user_input_array = { };
            //A while loop to check if the length is less or equal to 3
            while (user_input_array.Length <= 3)
            {
                try
                {
                    while (true) //A while loop so the user uses diff instead of anything else
                    {
                        Inputbox();
                        user_input_array = Console.ReadLine().Split(); //Read the user input

                        
                        if (user_input_array[0] == "diff") //If user inputted diff, then proceed
                        {
                            //Section for if the two files are the same                  
                            if (File.ReadAllText(user_input_array[1]) == File.ReadAllText(user_input_array[2]))
                            {
                                //Access the Diff Same class so the program could tell the user that the files are the same
                                DiffSame.Same(user_input_array);
                                break;
                            }
                            //Section for if the two files are different
                            else
                            {
                                //Access the change class to compare the files and show differences
                                DiffChange.Change(user_input_array);   
                                break;
                            }

                        }

                        
                        else //If user does not user diff, ask the usser to try again
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Trace.WriteLine("Please use diff");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }
                    Trace.WriteLine("\n");

                    break;
                }

                //Exception handling
                catch (FileNotFoundException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Trace.WriteLine("Files were not found, please try again");
                    Console.ForegroundColor = ConsoleColor.White;
                }

                catch (ArgumentException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Trace.WriteLine("Argument Exception, please try again");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                catch (IndexOutOfRangeException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Trace.WriteLine("Index Out Of Range Exception, please try again");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }

        }

        static void Inputbox()
        {
            Console.ForegroundColor = ConsoleColor.Yellow; //Change the input box to yellow
            Console.Write("[INPUT]: "); //Display the input box
            Console.ForegroundColor = ConsoleColor.White; //Change the colour of text back to white
        }
    }


}
