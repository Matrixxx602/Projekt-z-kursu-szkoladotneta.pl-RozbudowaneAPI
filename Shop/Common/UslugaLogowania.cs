using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class UslugaLogowania
    {
        public static void PiszDoPliku(List<ILogowanie> ZmienioneElementy)
        {
            foreach (var element in ZmienioneElementy)
            {
                Console.WriteLine(element.Log());
            }
        }
    }
}
