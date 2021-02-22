using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpProgex06
{
    class MOS
    {
      
        public virtual string AssignMOS()
        {
            string job = "You have no job";
            return job;
        }
        
    }
    class Bravo : MOS
    {
      
        public override string AssignMOS()
        {
            string job = "B";
            return job;
        }
    }
    class Charlie : MOS
    {
       
        public override string AssignMOS()
        {
            string job = "C";
            return job;
        }
    }
    class Delta : MOS
    {
       
        public override string AssignMOS()
        {
            string job = "D";
            return job;
        }
    }
    class Echo : MOS
    {
        public override string AssignMOS()
        {
            string job = "E";
            return job;
        }
    }
}
