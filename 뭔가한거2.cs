using System;

namespace gameProject
{
    internal class program
    {
        public int inteligence;
        public int num_company;

        public void MakeArc_Reactor()
        {
            Console.WriteLine("부모 기술");
            Console.WriteLine("아크발전기");
        }
        abstract public void make_new_resouce_arc();
    }
    class TonyStark : Haward_Stark
    {
        override public void make_new_resouce_arc()
        {
            Console.WriteLine("부모에 없는 기술");
            Console.WriteLine("신물질을 만든다 ");
        }
        public void MakeArc_Potable()
        {
            Console.WriteLine("개선된 재정의 기술");
            Console.WriteLine("휴대용 아크발전기");
        }
    }
static void Main(string[] args)
    {
       TonyStark tony = new TonyStark();
       tony.MakeArc_Reactor();
       Console.WriteLine("---------------");
       tony.MakeArc_Potable();
       Console.WriteLine("---------------");
       tony.make_new_resouce_arc();
    }
}