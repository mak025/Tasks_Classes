using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHero
{
    public class Hero
    {
        string _name;
        string _aprxage;
        string _gender;
        string _ability1;
        string _ability2;
        string _nemisisName;
        string _city;
    }
    public Hero(string name, string aprxage, string gender, string ability1, string ability2, string nemisisname, string city)
        {
            _name = name;
            _aprxage = aprxage;
            _gender = gender;
            _ability1 = ability2;
            _ability2 = ability2;
            _nemisisName = nemisisname;
            _city = city;
        }

        public override string ToString()
        {
            return $"The superhero of {_city} is named {_name} and is approximately {_age} years old. Their gender seems to be {_gender} and their abilities are {_ability1} and {_ability2}. They recently saved {_city} from {_nemisisName} horrible rule";
            ;
        }
    }
