using System;
using static System.Console;
using System.Linq;
using System.Reflection;

namespace NumberOfMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var r in Assembly.GetEntryAssembly().GetReferencedAssemblies())
            {
                var a = Assembly.Load(new AssemblyName(r.FullName));
                int methodCount = 0;
                foreach (var t in a.DefinedTypes)
                {
                    methodCount += t.GetMethods().Count();
                }
                WriteLine(
                    "{0:N0} types with {1:N0} methods in {2} Assembly.",
                    arg0: a.DefinedTypes.Count(),
                    arg1: methodCount,
                    arg2: r.Name);
            }
            //
            /*
            Block comment   
            */
            // Methods
        }
    }
}
