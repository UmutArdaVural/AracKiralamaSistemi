using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Araç_Kiralama_Ve_Yönetim
{
    public   class Sql_baglantı
    {
        public NpgsqlConnection Baglantı()
        {
            NpgsqlConnection baglan = new NpgsqlConnection("server=localhost; port=5432; Database=db_arac_kiralama; user Id=postgres; password=umutnisa72");
            baglan.Open(); // Bağlantıyı açar
            return baglan; // Bağlantıyı döndürür
        }
    }
}
