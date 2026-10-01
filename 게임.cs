namespace ConsoleApp1
{
    internal class Program
    {
        class MyData
        {
            public int m_x, m_y;
            private int m_z;
            protected int m_abe;

            public MyData(int x, int y, int z)
            {
                Console.WriteLine("생성자 값3개 세팅");
                m_x = x;
                m_y = y;
                m_z = z;
            }
            public MyData(int x)
            {
                Console.WriteLine("생성자 값1개 세팅");
                m_x = x;
                m_y = 0;
                m_z = 0;
            }
            public MyData(int y = 33, int z = 66)
            {
                Console.WriteLine("생성자 값2개 세팅");
                m_x = 3;
                m_y = y;
                m_z = z;
            }
            public void ShowData()
            {
                Console.WriteLine("-----------------------");
                Console.WriteLine("클래스 변수 data2");
                MyData data2 = new MyData(x: 123, z: 456, y: 000);
                data2.ShowData();
                Console.WriteLine("-----------------------");
            }
        }
    }
}
