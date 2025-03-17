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
        string _Phone; //is this person male or female?
        string _Ordernr; //how old is this person?
        string _Mail; //what is the persons profession?
        string _Confirmed; //what is the person studying or educated in?

        public Person(string name, string phone, string mail, string ordernr)
        {
            _Name = name;
            _Phone = phone;
            _Ordernr = ordernr;
            _Mail = mail;
        }

        public override string ToString()
        {
            return $"This person's name is {_Name}, their phone number is {_Phone}, email: {_Mail} and have the ordernumber: {_Ordernr}.";
        }

    }



}
