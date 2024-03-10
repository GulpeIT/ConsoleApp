using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class CorrectIPAddress
    {
        public bool is_valid_IP(string ipAddres)
        {
            string[] ip = ipAddres.Split('.', ' ', '-', '+', '=', '_'); // 0.012.0.0 => .0.

            if (ip.Length > 4 || ip.Length < 4) return false;

            for (int i = 0; i < ip.Length; i++)
            {
                if (!int.TryParse(ip[i], out int number)) return false;

                if (ip[i].Length != 1 && ip[i].StartsWith('0')) return false;

                if (int.Parse(ip[i]) < 0 || int.Parse(ip[i]) > 255) return false;
            }

            return true;
        }
    }
}
