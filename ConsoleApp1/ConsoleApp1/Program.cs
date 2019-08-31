using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;
using System.Windows;
using System.Data.Entity;
namespace Parser
{
    class Program
    {
        static void Main(string[] args)
        {
            using (TextFieldParser tpf = new TextFieldParser(@"C:\Users\lsi\source\repos\cinemcass\ConsoleApp1\bin\Debug\cinema.csv"))
            {
                tpf.TextFieldType = FieldType.Delimited;
                tpf.SetDelimiters(",");

                while (!tpf.EndOfData)
                {
                    string[] fields = tpf.ReadFields();
                   


                    

                     Console.Write(fields[0] + fields[1]+ fields[2]);
                                           
                    Console.ReadLine();
                    


                      
                    /*DbContext.fields.Add(fields);

                    // Сохранить изменения в базе данных
                    context.SaveChanges();*/
                }
            }
        }
    }
}
