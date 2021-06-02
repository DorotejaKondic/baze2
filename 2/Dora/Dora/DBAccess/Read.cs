using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dora.DBAccess
{
    class Read
    {
        public Read() { }
        
        public Biblioteka GetBiblioteka(short  id)
        {
            using (BibliotekaDBContainer db = new BibliotekaDBContainer())
            {
                return db.Bibliotekas.FirstOrDefault(x => x.PIB.Equals(id));
            }
        }

        public Bibliotekar GetBibliotekar(short  id)
        {
            using (BibliotekaDBContainer db = new BibliotekaDBContainer())
            {
                return db.Bibliotekars.FirstOrDefault(x => x.ID_Bibliotekara.Equals(id));
            }
        }

        public Clan GetClan(Int32 id)
        {
            using (BibliotekaDBContainer db = new BibliotekaDBContainer())
            {
                return db.Clans.FirstOrDefault(x => x.OsobaJMBG.Equals(id));
            }
        }

        public Clanarina GetClanarina(short  id)
        {
            using (BibliotekaDBContainer db = new BibliotekaDBContainer())
            {
                return db.Clanarinas.FirstOrDefault(x => x.ID_Clanarine.Equals(id));
            }
        }
        public Izdanje GetIzdanje(short  id)
        {
            using (BibliotekaDBContainer db = new BibliotekaDBContainer())
            {
                return db.Izdanjes.FirstOrDefault(x => x.Rbr_Izdanja.Equals(id));
            }
        }

        public Izdavac GetIzdavac(short  id)
        {
            using (BibliotekaDBContainer db = new BibliotekaDBContainer())
            {
                return db.Izdavacs.FirstOrDefault(x => x.ID_Izdavaca.Equals(id));
            }
        }
        public Knjiga GetKnjiga(int id)
        {
            using (BibliotekaDBContainer db = new BibliotekaDBContainer())
            {
                return db.Knjigas.FirstOrDefault(x => x.ID_Knjige.Equals(id));
            }
        }
        public Osoba GetOsoba(Int32 id)
        {
            using (BibliotekaDBContainer db = new BibliotekaDBContainer())
            {
                return db.Osobas.FirstOrDefault(x => x.JMBG.Equals(id));
            }
        }
        public Primerak GetPrimerak(int id)
        {
            using (BibliotekaDBContainer db = new BibliotekaDBContainer())
            {
                return db.Primeraks.FirstOrDefault(x => x.ID_Primerka.Equals(id));
            }
        }
        public Za_Iznajmljivanje GetIznajmljivanje(int id)
        {
            using (BibliotekaDBContainer db = new BibliotekaDBContainer())
            {
                return db.Za_Iznajmljivanje.FirstOrDefault(x => x.PrimerakID_Primerka.Equals(id));
            }
        }
        public Za_Prodaju GetProdaja(int id)
        {
            using (BibliotekaDBContainer db = new BibliotekaDBContainer())
            {
                return db.Za_Prodaju.FirstOrDefault(x => x.PrimerakID_Primerka.Equals(id));
            }
        }

        public List<Biblioteka> GetBiblioteke()
        {
            using (var db = new BibliotekaDBContainer())
            {
                List<Biblioteka> lista = db.Bibliotekas.ToList();

                return (lista != null) ? lista: new List<Biblioteka>();
            }
        }

        public List<Bibliotekar> GetBibliotekare()
        {
            using (var db = new BibliotekaDBContainer())
            {
                List<Bibliotekar> lista = db.Bibliotekars.ToList();

                return (lista != null) ? lista : new List<Bibliotekar>();
            }
        }
        public List<Clan> GetClanove()
        {
            using (var db = new BibliotekaDBContainer())
            {
                List<Clan> lista = db.Clans.ToList();

                return (lista != null) ? lista : new List<Clan>();
            }
        }
        public List<Clanarina> GetClanarine()
        {
            using (var db = new BibliotekaDBContainer())
            {
                List<Clanarina> lista = db.Clanarinas.ToList();

                return (lista != null) ? lista : new List<Clanarina>();
            }
        }
        public List<Izdanje> GetIzdanja()
        {
            using (var db = new BibliotekaDBContainer())
            {
                List<Izdanje> lista = db.Izdanjes.ToList();

                return (lista != null) ? lista : new List<Izdanje>();
            }
        }
        public List<Izdavac> GetIzdavaci()
        {
            using (var db = new BibliotekaDBContainer())
            {
                List<Izdavac> lista = db.Izdavacs.ToList();

                return (lista != null) ? lista : new List<Izdavac>();
            }
        }
        public List<Knjiga> GetKnjige()
        {
            using (var db = new BibliotekaDBContainer())
            {
                List<Knjiga> lista = db.Knjigas.ToList();

                return (lista != null) ? lista : new List<Knjiga>();
            }
        }
        public List<Osoba> GetOsobe()
        {
            using (var db = new BibliotekaDBContainer())
            {
                List<Osoba> lista = db.Osobas.ToList();

                return (lista != null) ? lista : new List<Osoba>();
            }
        }

        public List<Primerak> GetPrimerci()
        {
            using (var db = new BibliotekaDBContainer())
            {
                List<Primerak> lista = db.Primeraks.ToList();

                return (lista != null) ? lista : new List<Primerak>();
            }
        }


        public List<Za_Iznajmljivanje> GetIznajmljivanja()
        {
            using (var db = new BibliotekaDBContainer())
            {
                List<Za_Iznajmljivanje> lista = db.Za_Iznajmljivanje.ToList();

                return (lista != null) ? lista : new List<Za_Iznajmljivanje>();
            }
        }
        public List<Za_Prodaju> GetProdaje()
        {
            using (var db = new BibliotekaDBContainer())
            {
                List<Za_Prodaju> lista = db.Za_Prodaju.ToList();

                return (lista != null) ? lista : new List<Za_Prodaju>();
            }
        }
    }
}
