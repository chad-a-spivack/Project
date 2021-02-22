using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpProgex06
{
    class SFGroup
    {
      

   
    public static void AssignGroup(string location, string language)
        {
            string _location = location;
            string _language = language;
            if (location == "NC" && language == "french")
            {
                Console.WriteLine("You are becoming a member of 3rd Special Forces Group");
            }
            else if (location == "Clarksville"  && language == "Arabic")
            {
                Console.WriteLine("You are becoming a member of 5th Special Forces Group");
            }
            else if (location == "Destin" && language == "spanish")
            {
                Console.WriteLine("You are becoming a member of 7th Special Forces Group");
            }
            else if (location == "Colorado Springs" && language == "russian")
            {
                Console.WriteLine("You are becoming a member of 10th Special Forces Group");
            }
        }
        public virtual string AssignBase()
        {
            string homeBase = "You are assigned to SWCS at Fort Bragg";
            return homeBase;
        }
        public virtual string AOR()
        {
            string areaOfResponsibility = "You have no AOR";
            return areaOfResponsibility;
        }


    }
    class ThirdGroup : SFGroup
    {
     
        public override string AssignBase()
        {
            string Bragg = "You will be stationed at Fort Bragg in NC";
            return Bragg;
        }
        public override string AOR()
        {
            string AreaOf = "Africa is your AOR";
            return AreaOf;
        }

    }
    class FifthGroup : SFGroup
    {
       
        public override string AssignBase()
        {
            string Campbell = "You will be stationed at Fort Campbell in KY";
            return Campbell;
        }
        public override string AOR()
        {
            string AreaOf = "CENTCOM is your AOR";
            return AreaOf;
        }
    }
    class SeventhGroup : SFGroup
    {
    
        public override string AssignBase()
        {
            string Eglin = "You will be stationed at Eglin Air Base in FL";
            return Eglin;
        }
        public override string AOR()
        {
            string AreaOf = "SOUTHCOM is your AOR";
            return AreaOf;
        }
    }
    class TenthGroup : SFGroup
    {
        
        public override string AssignBase()
        {
            string Carson = "You will be stationed at Fort Carson in CO";
            return Carson;
        }
        public override string AOR()
        {
            string AreaOf = "Europe is your AOR";
            return AreaOf;
        }
    }
}
