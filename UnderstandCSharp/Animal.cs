using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandCSharp
{
    public class Animal
    {
        protected string name;

        public Animal()
        {
            this.name = "无名";
        }

        public Animal(string name)
        {
            this.name = name;
        }

        protected int _ShoutTimes = 3;

        /// <summary>
        /// 对_ShoutTimes字段进行封装，从而实现对_ShoutTimes的保护和控制
        /// </summary>
        public int ShoutTimes
        {
            get => _ShoutTimes;
            set => _ShoutTimes = value < 10 ? value : 10;
        }

    }
}
