using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandCSharp
{
    public class Cat : Animal
    {
        public Cat() :base()
        {
            
        }

        public Cat(string name) : base(name)
        {

        }

        public string Shout()
        {
            string strReturn = "";
            for (int i = 0; i < ShoutTimes; i++)
            {
                strReturn += "喵 ";
            }
            return "我是名字是：" +name+" "+ strReturn;
        }

    }
}
