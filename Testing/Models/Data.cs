using System;
using System.Collections.Generic;
using System.Linq;

namespace Testing.Models
{
    public class Data {
            public string Text { get; set; }
            public int Count { get; set; }


            public Data()
            {
                Init();
            }

            private void Init()
            {
                ReadFromFile();
                GetCount();
            }
            public override string ToString()
            {
                return $"Text of file: {Text}\n" +
                       $"and his word count is {Count}";
            }

            private string ReadFromFile()
            {
                return Text = System.IO.File.ReadAllText(@"C:\Users\dmytr\source\repos\TestWeb\Testing\DB\DataBaseFile.txt");
            }

            private void GetCount()
            {
                List<string> result = Text.Split(new [] { ',' }).ToList();
                Count = result.Count;
            }


    }

        
}
