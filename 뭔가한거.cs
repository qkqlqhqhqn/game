using System;

namespace gameProject
{
    internal class program
    {
        public class HowardTech
        {
            public virtual void MakeTeactor()
            {
                Console.WriteLine("일반 기술");
            }
        }

        public class TonyTech : HowardTech
        {
            public override void MakeTeactor()
            {
                Console.WriteLine("고급 기술");
            }
        }
        static void Main()
        {
            HowardTech factory = new HowardTech();
            factory.MakeTeactor();
            Console.WriteLine("-----------");
            TonyTech ironMan = new TonyTech();
            ironMan.MakeTeactor();
        }
    }
}