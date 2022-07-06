using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Components.Forms;

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

            private void ReadFromFile()
            {
                 Text = System.IO.File.ReadAllText(@"C:\Users\dmytr\source\repos\TestWeb\Testing\DB\DataBaseFile.txt");
            }

            private void GetCount()
            {
                Count = 0;
                int index = 0;
                while (index < Text.Length - 1)
                {
                    if (Text[index] == ' ' || Text[index] == '\n' || Text[index] == '\t')
                    {
                        Count++;
                    }

                    index++;
                }
                
            }
    }

        
}
