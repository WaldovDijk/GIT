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
            int m_Square = 0;
            int m_Type = 0;
            int m_PriceGlass = 0;
            int m_PriceWood = 0;
            int m_TotalPrice = 0;
            int m_Omtrek = 0; 
            int m_Standard = 30;
            int m_Hr = 45;
            int m_Hrp = 50;
            int m_Hrpp = 55;
            int m_Wood = 3;

            string m_Keuzen;

            
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




            if (m_Type == 1)
            {
                m_PriceGlass = m_Square * m_Standard;
            }
            if (m_Type == 2)
            {
                m_PriceGlass = m_Square * m_Hr;
            }
            if (m_Type == 3)
            {
                m_PriceGlass = m_Square * m_Hrp;
            }
            if (m_Type == 4)
            {
                m_PriceGlass = m_Square * m_Hrpp;
            }
            m_PriceWood = m_Omtrek * m_Wood;


            m_TotalPrice = m_PriceWood + m_PriceGlass;

        }
    }
}
