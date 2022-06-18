using System;

namespace HumanResources2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                HumanResources firstPerson = new HumanResources(HumanResources.Name("Name :"), HumanResources.Surname("Surname :"));
            }
        }
    }
}
class HumanResources
{
    public string _name;
    public string _surname;
    public string _fathersName;
    public string _finCode;
    public string _position;
    public int _phoneNumber;
    public int _salayr;
    public int _age;

    public HumanResources(string name, string surname, string fathersname, string fincode, string position, int phonenumber, int salary, int age)
    {
        _name = name;
        _surname = surname;
        _fathersName = fathersname;
        _finCode = fincode;
        _position = position;
        _phoneNumber = phonenumber;
        _salayr = salary;
        _age = age;
    }
    public HumanResources(string name, string surname)
    {
        this._name = name;
        this._surname = surname;
    }

    public static string Name(string name)
    {
        while (true)
        {
            Console.Write("Name :");
            string targetName = Console.ReadLine();
            char[] TargetSmallLetter = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            for (int i = 0; i < TargetSmallLetter.Length; i++)
            {
                if (targetName[0] == TargetSmallLetter[i])
                {
                    Console.WriteLine("Your format Incorrect");
                    break;
                }
                else if (targetName.Length > 20 || targetName.Length < 2)
                {
                    Console.WriteLine("Your Format Incorrect");
                    break;
                }

            }
            return name;
        }
    }
    public static string Surname(string surname)
    {
        while (true)
        {
            Console.Write("Surename :");
            string targetName = Console.ReadLine();
            char[] TargetSmallLetter = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            for (int i = 0; i < TargetSmallLetter.Length; i++)
            {
                if (targetName[0] == TargetSmallLetter[i])
                {
                    Console.WriteLine("Your format Incorrect");
                    break;
                }
                else if (targetName.Length > 20 || targetName.Length < 2)
                {
                    Console.WriteLine("Your Format Incorrect");
                    break;
                }
            }
            return surname;
        }
    }
}
