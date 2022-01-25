using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorsInInheritance8523
{
    class Program
    {
        static void Main(string[] args)
        {
            SubClass sub = new SubClass("sub", "base");
            sub.BaseMethod();
            sub.SubMethod();
            
            Console.ReadLine();
        }
    }
    abstract class BaseClass
    {
        private string _baseField;

        //public BaseClass(string baseField)
        protected BaseClass(string baseField)
        {
            _baseField = baseField;
            Console.WriteLine("Base constructor executed with " + _baseField);
        }
        public void BaseMethod()
        {
            Console.WriteLine("Base method executed with " + _baseField);
        }
    }
    class SubClass : BaseClass
    {
        private string _subField;
        
        public SubClass(string subField,string baseField) : base(baseField)
        {
            _subField = subField;
            Console.WriteLine("Sub constructor executed with " + _subField);
        }
        public void SubMethod()
        {
            Console.WriteLine("Sub method executed with " + _subField);
        }
    }
}
