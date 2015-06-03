using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingDebugClass
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1, b = 2, c = 3;

            Debug.WriteLine("Debug Information-Product Starting");
            Debug.Indent();

            Debug.WriteLine("The value of a is " + a.ToString());
            Debug.WriteLine("The value of b is " + b.ToString());
            Debug.WriteLine("The value of c is " + c.ToString());

            Debug.WriteLine("The value of a is " + a.ToString(), "Test");
            Debug.WriteLine("The value of b is " + b.ToString(), "Test");
            Debug.WriteLine("The value of c is " + c.ToString(), "Test");

            Debug.WriteLineIf(a < 5, "This message will appear in the output box."); 
            Debug.WriteLineIf(a > 2, "This message will not appear.");

            Debug.Assert(a < 5, "This message will appear in the output box.");
            Debug.Assert(a < 2, "This message will not appear.");

            TextWriterTraceListener tr1 = new TextWriterTraceListener(System.Console.Out);
            Debug.Listeners.Add(tr1);
            TextWriterTraceListener tr2 = new TextWriterTraceListener(System.IO.File.CreateText("Output.txt"));
            Debug.Listeners.Add(tr2);

            Debug.WriteLine("The value of a is " + a.ToString());
            Debug.WriteLine("The value of a is " + b.ToString());
            Debug.WriteLine("The value of a is " + c.ToString());
 
            Debug.Unindent();
            Debug.WriteLine("Debug Information-Product Ending");
 
            Debug.Flush(); 
            Console.ReadKey(); 
        }
    }
}
