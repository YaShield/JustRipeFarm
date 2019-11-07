using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_7
{
    class Labourer
    {
        private int id;
        private string name;
        private int age;
        private string gender;
        //private string createTime;

        public int Id 
        { 
            get => id; 
            set => id = value; 
        }
        public string Name 
        { 
            get => name; 
            set => name = value; 
        }
        public int Age 
        { get => age; 
            set => age = value; 
        }
        public string Gender 
        { get => gender; 
            set => gender = value; 
        }
        //public string CreateTime { get => createTime; set => createTime = value; }
    }
   
}
