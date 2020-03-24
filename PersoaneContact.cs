using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicatieTipAgenda
{
    /// <summary>
    /// Persoanele de contact din agenda
    /// </summary>
   public class PersoaneContact
    {
        public string nume;
        public string numarTelefon;
        public string adresaEmail;

        public DateTime DataNasterii;
        /// <summary>
        /// Constructor cu parametri
        /// </summary>
        /// <param name="numePersoana"></param>
        /// <param name="nrTel"></param>
        /// <param name="e_mail"></param>
        public PersoaneContact(string numePersoana, string nrTel, string e_mail)
        {
            nume = numePersoana;
            numarTelefon = nrTel;
            adresaEmail = e_mail;

        }
        public string Info()
        {
            return "Persoana de contact are numele " + nume + " cu numarul de telefon: " + numarTelefon + " si adresa de e-mail: " + adresaEmail;
        }

    }
}
