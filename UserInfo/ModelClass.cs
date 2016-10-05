using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UserInfo
{
    public class ModelClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string  Details { get; set; }

        public void ShowExp()
        {

            Console.WriteLine(Name);
        }
    }
}