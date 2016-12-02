using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Server
{
    public class ClassServer : CollectionBase
    {
        string str1 = "";
        string str2 = "";
        string str3 = "";
        string str4 = "";

        public string Extraction()
        {
            str1 = "Извлечение из html-кода необходимых данных";

            Thread.Sleep(10);
            this.Save();
            return str1;
        }

        public string Save()
        {
            str2 = "Фиксация результата";
            Thread.Sleep(7);
            this.Treatment();
            return str2;
        }

        public string Treatment()
        {
            str3 = "Обработка и формирование результата";

            Thread.Sleep(5);
            this.Vivod();
            return str3;
        }

        public string Vivod()
        {
            str4 = "Вывод результата в файл или на экран";
            Thread.Sleep(5);
            return str4;
        }
    }
}
