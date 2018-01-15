using System;

namespace Stateless
{
    class Stateless
    {
        static void Main(string[] args)
        {
            while(true)
            {
                string state = Console.ReadLine();
                if (state == "collapse")
                {
                    break;
                }
                string fiction = Console.ReadLine();

                while (fiction != String.Empty)
                {
                    if (state.Contains(fiction))
                    { 
                        while (true)
                        {
                            var index = state.IndexOf(fiction);
                            if (index == -1)
                            {
                                break;
                            }
                            state = state.Remove(index, fiction.Length);                                                                         
                        }                      
                    }

                    if (fiction.Length == 1)
                    {
                        fiction = String.Empty;
                        continue;
                    }
                    fiction = fiction.Substring(1, fiction.Length - 2);
                }
                
                if (state != String.Empty)
                {
                    Console.WriteLine(state.Trim());
                }
                else
                {
                    Console.WriteLine("(void)");
                }
            }
        }
    }
}
