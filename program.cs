using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters;

namespace Array
{
    internal class Program
    {
        struct UserData1
        {
            public int Id;
            public float point;
            public void ShowData()
            {
                Console.WriteLine("ID: "+Id+"점수"+point);
            }
        }
        struct UserData2
        {
            int age;
            public void ShowData()
            {
                Console.WriteLine("나이:" + age);
            }
        }
        static void Main(string[] args)
        {
            int[] scores;
            scores = new int[5];
            scores[1] = 5;
            Console.WriteLine(scores[0]);
            for(int i=0; i<scores.Length; i++)
            {
                Console.WriteLine(scores[i]);
            }

            float[] data_float;
            data_float = new float[3] { 1.1f, 2.2f, 3.3f };

            string[] data_str = new string[3] { "aaa", "bbb", "ccc" };

            for(int i=0; i<data_float.Length; i++)
            {
                Console.WriteLine(data_float[i] + data_str[i]);
            }
            foreach(string v in data_str)
            {
                Console.WriteLine(v);
            }
            Console.WriteLine("구조체 사용");
            UserData1 mydata1;
            mydata1.Id = 1;
            mydata1.point = 2.11f;
            mydata1.ShowData();

            UserData2 mydata2 = new UserData2();
            mydata2.ShowData();
        }
    }
}
