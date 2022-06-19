using System;

namespace HumanResources2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {


                while (true)
                {


                    Console.Write("Adinizi Daxil edin :");
                    string targetName = Console.ReadLine();
                    string result = Human.Name(targetName);
                    break;



                }
                while (true)
                {
                    Console.Write("Soyadinizi Daxil edin :");
                    string targetSurname = Console.ReadLine();
                    string resultSurname = Human.Surname(targetSurname);
                    break;

                }
                while (true)
                {
                    Console.Write("Atanizin Adini Daxil edin :");
                    string targetFatherName = Console.ReadLine();
                    string resultFatherName = Human.Father(targetFatherName);
                    break;
                }
                while (true)
                {
                    Console.Write("Fincodunuzu Daxil edin :");
                    string FinCode = Console.ReadLine();
                    string resultFinCode = Human.Fincode(FinCode);
                    break;
                }
            }


        }


    }
}

class Human
{
    public string _name;
    public string _surname;
    public string _FaterName;
    public string _Fincode;

    public Human(string name , string surname,string father,string fincode)
    {
        _name = name;
        _surname = surname;
        _FaterName = father;
        _Fincode = fincode;
    }

    public static string Name(string targetName)
    {
        char[] TargetSmallLetter = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p',
                'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        for (int i = 0; i < TargetSmallLetter.Length; i++)
        {
            if (targetName[0] == TargetSmallLetter[i])
            {
                Console.WriteLine($"Adin ({targetName}) Bas Herifi Boyuk Olmalidir");
                Console.WriteLine(targetName);
                break;
            }
            else if (targetName.Length > 20 || targetName.Length <= 2)
            {
                Console.WriteLine($"Adin ({targetName}) Uzunluqu sehfdir");
                Console.WriteLine(targetName);
                break;
            }
        }
        return targetName;
    }
    public static string Surname(string targetSurname)
    {
        char[] TargetSmallLetter = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p',
                'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

        for (int i = 0; i < TargetSmallLetter.Length; i++)
        {
            if (targetSurname[0] == TargetSmallLetter[i])
            {
                Console.WriteLine($"Soyadinizin ({targetSurname}) Bas Herifi Boyuk olmalidi");
                Console.WriteLine(targetSurname);
                break;
            }
            else if (targetSurname.Length > 20 || targetSurname.Length <= 2)
            {
                Console.WriteLine($"Soyadinizin ({targetSurname}) Uzunluqu sehfdir");
                Console.WriteLine(targetSurname);
                break;
            }
        }
        return targetSurname;
    }
    public static string Father(string targetFatherName)
    {
        char[] TargetSmallLetter = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p',
                'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

        for (int i = 0; i < TargetSmallLetter.Length; i++)
        {
            if (targetFatherName[0] == TargetSmallLetter[i])
            {
                Console.WriteLine($"Adin ({targetFatherName}) Bas Herfi Boyuk Olmalidir");
                Console.WriteLine(targetFatherName);
                break;
            }
            else if (targetFatherName.Length > 20 || targetFatherName.Length <= 2)
            {
                Console.WriteLine($"Adin ({targetFatherName}) uzunluqu sehfdir");
                Console.WriteLine(targetFatherName);
                break;
            }
        }
        return targetFatherName;
    }
    public static string Fincode(string FinCode)
    {
        char[] TargetSmallLetter = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p',
                'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

        for (int i = 0; i < TargetSmallLetter.Length; i++)
        {
            if (FinCode.Length != TargetSmallLetter[i])
            {
                Console.WriteLine($"Fincodun ({FinCode}) Butun Herifleri Boyuk Olmalidir");
                Console.WriteLine(FinCode);
                break;
            }
            else if (FinCode.Length == 7)
            {
                
                Console.WriteLine($"Fincodunuzun ({FinCode}) uzunluqu sehfdir (7 e Beraber olmalidir)");
                Console.WriteLine(FinCode);
                break;
            }
        }
        return FinCode;
    }

}