using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation_Task1
{
    public class Student
    {
        private int _ID;

        public int ID 
        {
            get
            {
                return _ID;
            } 
            
            set 
            {
                _ID = value;
            } 
        }

        private string _Ad;

        public string Ad
        {
            get
            {
                return _Ad;
            }

            set
            {
                _Ad = value;
            }
        }

        private string _Soyad;

        public string Soyad
        {
            get
            {
                return _Soyad;
            }

            set
            {
                _Soyad = value;
            }
        }

        private string _Ixtisas;

        public string Ixtisas
        {
            get
            {
                return _Ixtisas;
            }

            set
            {
                _Ixtisas = value;
            }
        }

       
    }
}
