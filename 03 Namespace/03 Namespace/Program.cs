using System;
using System.Runtime.InteropServices;
using PATA = ProjectA.TeamA;
using PATB = ProjectA.TeamB;

public class Program
{
    public static void Main(string[] args)
    {
        PATA.ClassA.Print();
        PATB.ClassA.Print();

    }
}