using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueBook
{
    public class Person
    {
        string _Name; //what is this persons name?
        string _Gender; //is this person male or female?
        int _Age; //how old is this person?
        string _Profession; //what is the persons profession?
        string _StudyField; //what is the person studying or educated in?

        public Person(string name, string gender, int age, string profession, string study)
        {
            _Name = name;
            _Gender = gender;
            _Age = age;
            _Profession = profession;
            _StudyField = study;
        }

        public override string ToString()
        {
            return $"This person's name is {_Name}, they are {_Age} years old, identify as {_Gender}, work as {_Profession}, and studied {_StudyField}.";
        }

    }



}
