using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace raammakerkeesjan
{
    class Program
    {
        static void Main(string[] args)
        {
            int m_Square;
            int m_Type;
            int m_wood;
            string m_keuzen;
            Console.WriteLine("welkom, wat voor een soort raam zoekt u?");
            Console.WriteLine("1.Standaart: 30 Euro");
            Console.WriteLine("2.HR: 45 Euro");
            Console.WriteLine("3.HR+: 50 Euro");
            Console.WriteLine("4.HR++: 55 Euro");
            m_Type = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("hoeveel vierkante meter wilt u?");
            m_Square = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("wilt u hout eromheen?");
            
            




        }
    }
}
