using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokempn01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            monster Pokempn = new monster()
            {
                name = "妙娃種子",
                hp = "60",
                gender = "男"
            };
            Console.WriteLine("名字:{0}, 血量:{1}, 性別:{2}"
                , Pokempn.name
                , Pokempn.hp
                , Pokempn.gender
            );
        }
    }
}