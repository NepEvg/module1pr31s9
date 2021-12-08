using System;

namespace module1pr31s9
{
    public class Program
    { 
        public static void Main(string[] args)
        {
            Console.Write("введите фамиилию: ");
            string name = Console.ReadLine();
            Console.Write("введите число программ: ");
            int prog = Convert.ToInt32(Console.ReadLine());
            Console.Write("введите число языков: ");
            int lang = Convert.ToInt32(Console.ReadLine());
            Programmer p = new Programmer(name, prog, lang);
            Console.WriteLine("фамилия: " + p.Name);
            Console.WriteLine("число программ: " + p.Program);
            Console.WriteLine("число языков: " + p.Language);
            int ans = p.schetQ();
            Console.WriteLine("качество объекта: " + ans);
            Nasled n = new Nasled(name, prog, lang);
            Console.WriteLine("качество объекта класса потомка: " + n.chetQp(ans));
            Console.ReadLine();
        }
    }
}