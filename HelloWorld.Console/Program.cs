using System;
using System.Reflection;

public class Program
{
    public static void Main()
    {
		var asm = Assembly.Load(new AssemblyName("klr.host"));
		var asmV = asm.GetCustomAttribute<AssemblyInformationalVersionAttribute>();
        Console.WriteLine(String.Format("Hello World from {0}", asmV.InformationalVersion));		
    }
}
