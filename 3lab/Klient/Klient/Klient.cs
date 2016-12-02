using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Klient
{
    class ClassPC
    {

        public void load()
        {
            Thread.Sleep(100);
            Console.WriteLine("Загрузка файла на сервер");
        }

    }
}
