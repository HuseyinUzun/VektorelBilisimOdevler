using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emlak1
{

    public class Emlak
    {
        public string Adres;
        public double Fiyat;
        public int Metrekare;
    }

    
    public class Konut : Emlak
    {
        public int OdaSayisi;
        public bool Balkon;
    }

    public class Ev : Konut
    {
        
    }
    public class KiralikEv : Ev
    {
        public int KonutSuresi;
    }
    public class SatilikEv : Ev
    {

    }
    public class Villa : Konut
    {

    }
    public class KiralikVilla : Villa
    {

    }
    public class SatilikVilla : Villa
    {

    }
    public class Arsa : Emlak
    {
        public bool ImarVarmi;
       
    }
    public class KiralikArsa : Arsa
    {

    }
    public class SatilikArsa : Arsa
    {

    }
    public class KiralikEmlakBilgileri
    {
        public decimal Deposito;
        public int KontratBilgileri;

    }
    public class Sehir
    {
        public int sehirKodu;
        public string ad;

    }
    public class Adres
    {
        public string ad;
        public string semt;
        public string cadde;
        public string mahalle;

    }


}
