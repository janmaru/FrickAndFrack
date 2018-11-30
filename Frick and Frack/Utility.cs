using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;

namespace Frick_and_Frack
{
    public class Utility
    {
        [AccussìAccussì("Si poteva fare meglio")]
        public string Validate(string email)
        {
            if (email == string.Empty || email == null)
                return string.Empty;
            else
                return email;
        }

        [NaMezaChiavica("Va beh, dai")]
        public string Validate2(string email)
        {
            if (email == string.Empty || email == null)
                return string.Empty;
            try
            {
                MailAddress m = new MailAddress(email);
            }
            catch (FormatException)
            {
                return string.Empty;
            }
            return email;
        }

        [MaggCecat("Almeno sai dichiarare un array inline")]
        public string Validate3(string email)
        {
            if (email == string.Empty || email == null)
                return string.Empty;
            string[] chrs = { "#", "_", "7", "mah" };
            foreach (var c in chrs)
            {
                if (email.Contains(c))
                    email = string.Empty;
            }
            return email;
        }

        [TuttBenOFrà("Adesso me la vedo io")]
        public static bool Validate4(string email)
        {
            return (String.IsNullOrEmpty(email) ? false : true);
        }

        [SciòCinque("Adesso me la vedo io")]
        public static bool Validate5(string email)
        {
            return Regex.IsMatch(email,
                @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                RegexOptions.IgnoreCase);
        }


    }
}
