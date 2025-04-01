using System;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

public class Program
{
    static void Main()
    {
    string activity = " ";
    do
    {
        Mindfullness_app mind = new Mindfullness_app();
        activity = mind.Menu();  

    }while(activity != "5");
    
    }
}

    