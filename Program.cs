using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace stream_homework
{
    class Program
    {
        static void Main(string[] args)


        {
            // first create an instance of streamreader to read from a file
            StreamReader reader = new StreamReader("shakespeare.txt");

            //next initialize variables
            int linenumber = 0;

            // then read only the first line from the text file
            string line = reader.ReadLine();
            Console.WriteLine(line);
                        
            //then create a second instance of streamreader to read from a file
            StreamReader readerb = new StreamReader("shakespeare.txt");

            //next initialize variables
            int linenumberb = 0;

            //then read the whole passage
            string lineb = readerb.ReadLine();

            while (lineb != null)
            {
                linenumberb++;
                Console.WriteLine("lineb {0}: {1}", linenumberb, lineb);
                lineb = readerb.ReadLine();
            }
            //close the resource after you've finished using it
            readerb.Close();





            //Then create a third instance of streamreader to read from a file
            StreamReader readerc = new StreamReader("Shakespeare.txt");

            //Next initialize variables
            int linenumberc = 0;

            //Then read the whole passage
            string linec = readerc.ReadLine();

            while (linec != null)
            {
                linenumberc++;
                Console.WriteLine(capitalizeVowels(linec));
                linec = readerc.ReadLine();
            }
            readerc.Close();
        }

        public static string capitalizeVowels(string linec)
        {
            if (string.IsNullOrEmpty(linec))
                return linec;
            else
            {
                HashSet<char> vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };
                return new string(linec.Select(x => vowels.Contains(x) ? char.ToUpper(x) : x).ToArray());
            }
        }

      

    }
    
}
                
        
      
        
    
