using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpProgex06
{
    class Language
    {
      
        public virtual string AssignLanguage()
        {
            string lang = "Don't worry about it";
            return lang;
        }
    }
    class Arabic : Language
    {
       
        public override string AssignLanguage()
        {
            string lang = "arabic";
            return lang;
        }

    }
    class Russian : Language
    {
     
        public override string AssignLanguage()
        {
            string lang = "arabic";
            return lang;
        }
    }
    class Spanish : Language
    {
        
        public override string AssignLanguage()
        {
            string lang = "arabic";
            return lang;
        }
    }
    class French : Language
    {
      
        public override string AssignLanguage()
        {
            string lang = "french";
            return lang;
        }

    }
}
