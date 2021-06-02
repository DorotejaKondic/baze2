using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dora.DBAccess
{
    class Update
    {
        private Read read;
        public Update()
        {
            read = new Read();
        }

        public void UpdateBiblioteka(short pib, string naziv, string adresa)
        {
            Biblioteka biblioteka = read.GetBiblioteka(pib);
            biblioteka.PIB = pib != biblioteka.PIB ? pib : biblioteka.PIB;
            biblioteka.Naziv = naziv != biblioteka.Naziv ? naziv : biblioteka.Naziv;
            biblioteka.Adresa = adresa != biblioteka.Adresa ? adresa : biblioteka.Adresa;

            using (var db = new BibliotekaDBContainer())
            {
                db.Entry(biblioteka).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }

        }

        public void UpdateBibliotekar(short id, string ime, string prezime, short pib)
        {
            Bibliotekar bibliotekar = read.GetBibliotekar(id);
            bibliotekar.ID_Bibliotekara = id!= bibliotekar.ID_Bibliotekara ? id: bibliotekar.ID_Bibliotekara;
            bibliotekar.Ime= ime!= bibliotekar.Ime? ime: bibliotekar.Ime;
            bibliotekar.Prezime = prezime != bibliotekar.Prezime ? prezime : bibliotekar.Prezime;
            bibliotekar.BibliotekaPIB = pib != bibliotekar.BibliotekaPIB ? pib : bibliotekar.BibliotekaPIB;

            using (var db = new BibliotekaDBContainer())
            {
                db.Entry(bibliotekar).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }

        }
        public void UpdateClan(Int32 id, Int32 jmbg)
        {
            Clan clan = read.GetClan(id);
            clan.ID_clana = id != clan.ID_clana? id : clan.ID_clana;
            clan.ID_clana = jmbg != clan.OsobaJMBG ? jmbg: clan.OsobaJMBG;
            using (var db = new BibliotekaDBContainer())
            {
                db.Entry(clan).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }

        }       
        
        
        public void UpdateClanarina(short id, Int32 cena)
        {
            Clanarina clanarina = read.GetClanarina(id);
            clanarina.ID_Clanarine = id != clanarina.ID_Clanarine ? id : clanarina.ID_Clanarine;
            clanarina.Cena = cena != clanarina.Cena? cena : clanarina.Cena;
            using (var db = new BibliotekaDBContainer())
            {
                db.Entry(clanarina).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }

        }
        public void UpdateIzdanje(short id, short idknj, short idizd)
        {
            Izdanje izdanje= read.GetIzdanje(id);
            izdanje.Rbr_Izdanja = id != izdanje.Rbr_Izdanja? id : izdanje.Rbr_Izdanja;
            izdanje.KnjigaID_Knjige = idknj != izdanje.KnjigaID_Knjige ? idknj : izdanje.KnjigaID_Knjige;
            izdanje.IzdavacID_Izdavaca = idizd != izdanje.IzdavacID_Izdavaca ? idizd : izdanje.IzdavacID_Izdavaca;
            using (var db = new BibliotekaDBContainer())
            {
                db.Entry(izdanje).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }

        }  
        public void UpdateIzdavac(short id, string naziv, short rbr)
        {
            Izdavac izdavac= read.GetIzdavac(id);
            izdavac.ID_Izdavaca = id != izdavac.ID_Izdavaca ? id : izdavac.ID_Izdavaca;
            izdavac.Naziv_Izdavaca = naziv != izdavac.Naziv_Izdavaca ? naziv : izdavac.Naziv_Izdavaca;
            izdavac.IzdanjeRbr_Izdanja = rbr != izdavac.IzdanjeRbr_Izdanja ? rbr: izdavac.IzdanjeRbr_Izdanja;
            using (var db = new BibliotekaDBContainer())
            {
                db.Entry(izdavac).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }

        }
        public void UpdateKnjiga(short id, string autor, string naziv, Int32 kolicina, string zanr)
        {
            Knjiga knjiga= read.GetKnjiga(id);
            knjiga.ID_Knjige = id != knjiga.ID_Knjige ? id : knjiga.ID_Knjige;
            knjiga.Autor = autor != knjiga.Autor ? autor : knjiga.Autor;
            knjiga.Naziv = naziv != knjiga.Naziv ? naziv : knjiga.Naziv;
            knjiga.Kolicina = kolicina != knjiga.Kolicina ? kolicina : knjiga.Kolicina;
            knjiga.Zanr = zanr != knjiga.Zanr ? zanr : knjiga.Zanr;
            using (var db = new BibliotekaDBContainer())
            {
                db.Entry(knjiga).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }

        }
        public void UpdateOsoba(Int32 id, string ime, string prezime,string mejl, string adresa)
        {
            Osoba osoba = read.GetOsoba(id);
            osoba.JMBG = id != osoba.JMBG ? id : osoba.JMBG;
            osoba.Ime = ime != osoba.Ime ? ime : osoba.Ime;
            osoba.Prezime = prezime != osoba.Prezime ? prezime : osoba.Prezime;
            osoba.Mejl = mejl != osoba.Mejl ? mejl : osoba.Mejl;
            osoba.Adresa = adresa != osoba.Adresa ? adresa : osoba.Adresa;
            using (var db = new BibliotekaDBContainer())
            {
                db.Entry(osoba).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }

        }
        public void UpdatePrimerak(short id, short rbr)
        {
            Primerak primerak= read.GetPrimerak(id);
            primerak.ID_Primerka = id != primerak.ID_Primerka ? id : primerak.ID_Primerka;
            primerak.IzdanjeRbr_Izdanja = rbr != primerak.IzdanjeRbr_Izdanja ? rbr : primerak.IzdanjeRbr_Izdanja;

            using (var db = new BibliotekaDBContainer())
            {
                db.Entry(primerak).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }

        }
        public void UpdateZaIznajmljivanje(short id, string datum)
        {
            Za_Iznajmljivanje izn= read.GetIznajmljivanje(id);
            izn.PrimerakID_Primerka = id != izn.PrimerakID_Primerka ? id : izn.PrimerakID_Primerka;
            izn.Datum_Iznajmljivanja = datum != izn.Datum_Iznajmljivanja ? datum : izn.Datum_Iznajmljivanja;

            using (var db = new BibliotekaDBContainer())
            {
                db.Entry(izn).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }

        }
        public void UpdateZaProdaju(short id, Int64 cena)
        {
            Za_Prodaju prodaja= read.GetProdaja(id);
            prodaja.PrimerakID_Primerka = id != prodaja.PrimerakID_Primerka ? id : prodaja.PrimerakID_Primerka;
            prodaja.Cena_Knjige = cena!= prodaja.Cena_Knjige? cena: prodaja.Cena_Knjige;

            using (var db = new BibliotekaDBContainer())
            {
                db.Entry(prodaja).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }

        }
    }
}
