using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class ClassA
{
    private int privateFieldA = 88;

    public int GetPrivateFieldA()
    {
        return privateFieldA;
    }
}

class ClassB
{
    public int AccessPrivateFieldFromA()
    {
        ClassA classAObject = new ClassA();
        return classAObject.GetPrivateFieldA();
    }
}

class Program
{
    static void Main(string[] args)
    {
        ClassB classBObject = new ClassB();

        int valueFromA = classBObject.AccessPrivateFieldFromA();
        Console.WriteLine("Value from ClassA: " + valueFromA);
    }
}