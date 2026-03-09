using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentMS
{
    internal class ApartmentDal
    {
        public ApartmentDal() 
        { 

        }

        public string GetConnString()
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CSharp\WinFormsNetFmwk1\ApartmentMS\Apartment.mdf;Integrated Security=True";
        }

        public static string Flatid { get; set; }


    }
}
