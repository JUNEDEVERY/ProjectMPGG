using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace proba
{
    internal class DebugAndTrace
    {
        public static void testing(string Login, string Surname, string Name, string Patronomic, string Login1, string[] buy, string[] add)
        {
            Trace.Listeners.Add(new TextWriterTraceListener("Debug.txt"));
            Debug.Indent();
            Trace.Indent();
            Trace.WriteLine("\n");
            Debug.WriteLine("Дата: {0}", DateTime.Today);
            Debug.WriteLine("Debug");
            Trace.WriteLine("Trace");
            if(Login != null)
            {
                Debug.WriteLine("Вход в программу: " + Login);
            }
            if (Login1 != null)
            {
                Debug.WriteLine("Пользователь добавлен: " + Surname + " " + Name + " " + Patronomic + "\nЛогин: " + Login1);
            }
            if (add[0] != null)
            {
                Debug.WriteLine("Пользователь добавил в магазин товары:");
                for (int i = 0; i < add.Length - 1; i++)
                {
                    Debug.WriteLine(i+1 + ") " + add[i]);
                }
            }
            if (buy[0] != null)
            {
                Debug.WriteLine("Пользователь совершил продажу товаров:");
                for (int i = 0; i < buy.Length - 1; i++)
                {
                    Debug.WriteLine(i+1 + ") " + buy[i]);
                }
            }
            Trace.Flush();
        }
    }
}
