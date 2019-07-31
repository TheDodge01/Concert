using System;
using System.Collections.Generic;
using System.Linq;

namespace Concert
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, List<string>> bands = new Dictionary<string, List<string>>();

            Dictionary<string, int> playTime = new Dictionary<string, int>();


            string input = Console.ReadLine();

            while (input != "start of concert")
            {
                string[] args = input.Split("; ");

                string command = args[0];
                string name = args[1];

                if (command == "Add")
                {
                    List<string> members = args[2]
                            .Split(", ")
                            .ToList();

                    if (!bands.ContainsKey(name))
                    {
                        bands.Add(name, members);
                    }
                    else
                    {
                        foreach (var member in members)
                        {
                            if (!bands[name].Contains(member)) 
                            {
                                bands[name].Add(member);
                            }
                        }
                    }
                }
                else
                {
                    int time = int.Parse(args[2]);

                    if (!playTime.ContainsKey(name))
                    {
                        playTime.Add(name, time);
                    }
                    else
                    {
                        playTime[name] += time;
                    }
                }

                input = Console.ReadLine();
            }
        }
    }
}
