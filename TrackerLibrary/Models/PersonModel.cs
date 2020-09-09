using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    /// <summary>
    /// Reprezentuje jedna osobe
    /// </summary>
    public class PersonModel
    {
        /// <summary>
        /// Imie osoby
        /// </summary>
        
        public string FirstName { get; set; }
       
        /// <summary>
        /// Nazwisko osoby
        /// </summary>
        
        public string LastName { get; set; }
       
        /// <summary>
        /// Adres E-mail osoby
        /// </summary>
        
        public string EmailAdress { get; set; }

        /// <summary>
        /// Numer Komorkowy(telefon) osoby
        /// </summary>
        /// 
        public string CellphoneNumber { get; set; }
    }
}
