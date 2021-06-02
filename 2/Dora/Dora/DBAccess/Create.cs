using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dora.DBAccess
{
    class Create
    {
        private Read read;
        public Create()
        {
            read = new Read();
        }
        public Tuple<bool, string> AddBibilioteka(short id, string naziv, string adresa)
        {

            if (id == 0|| String.IsNullOrEmpty(naziv) || String.IsNullOrEmpty(adresa))
            {
                System.Windows.MessageBox.Show("Popuni sva polja!");

                return new Tuple<bool, string>(false, "Popuni sva polja!");
            }
            else if (read.GetBiblioteka(id) != null)
            {
                System.Windows.MessageBox.Show($"Biblioteka sa PIBom {id} postoji!");

                return new Tuple<bool, string>(false, $"Biblioteka sa PIBom {id} postoji!");

            }
            else
            {
                using (BibliotekaDBContainer db = new BibliotekaDBContainer())
                {
                    Biblioteka biblioteka = new Biblioteka();
                    biblioteka.PIB = id;
                    biblioteka.Naziv = naziv;
                    biblioteka.Adresa = adresa;

                    db.Bibliotekas.Add(biblioteka);
                    db.SaveChanges();
                    System.Windows.MessageBox.Show($"Dodata biblioteka poda nazivom -  {naziv} ");
                    return new Tuple<bool, string>(true, $"Dodata biblioteka poda nazivom -  {naziv} ");

                }
            }


        }
        public Tuple<bool, string> AddBibiliotekar(short id, string ime, string prezime, short pib)
        {

            if (id == 0 || String.IsNullOrEmpty(ime) || String.IsNullOrEmpty(prezime) || pib == 0)
            {
                System.Windows.MessageBox.Show("Popuni sva polja!");

                return new Tuple<bool, string>(false, "Popuni sva polja!");
            }
            else if (read.GetBibliotekar(id) != null)
            {
                System.Windows.MessageBox.Show($"Bibliotekar sa IDom {id} postoji!");

                return new Tuple<bool, string>(false, $"Bibliotekar sa IDom {id} postoji!");
            }
            else
            {
                using (BibliotekaDBContainer db = new BibliotekaDBContainer())
                {
                    Bibliotekar bibliotekar = new Bibliotekar()
                    {
                        ID_Bibliotekara = id,
                        Ime = ime,
                        Prezime = prezime,
                        BibliotekaPIB = pib
                    };

                    db.Bibliotekars.Add(bibliotekar);
                    db.SaveChanges();
                    System.Windows.MessageBox.Show($"Dodat bibliotekar pod imenom -  {ime} ");

                    return new Tuple<bool, string>(true, $"Dodat bibliotekar pod imenom -  {ime} ");
                }
            }
        }
        public Tuple<bool, string> AddClan(Int32 id, Int32 jmbg)
        {

            if (id == 0 || jmbg == 0)
            {
                return new Tuple<bool, string>(false, "Popuni sva polja!");
            }
            else if (read.GetClan(id) != null)
            {
                return new Tuple<bool, string>(false, $"Clan sa IDom {id} postoji!");
            }
            else
            {
                using (BibliotekaDBContainer db = new BibliotekaDBContainer())
                {
                    Clan clan = new Clan()
                    {
                        ID_clana = id,
                        OsobaJMBG = jmbg,
                        
                    };

                    db.Clans.Add(clan);
                    db.SaveChanges();
                    return new Tuple<bool, string>(true, $"Dodat clan pod IDom-  {id} ");
                }
            }
        }

         public Tuple<bool, string> AddClanarina(short id, Int32 cena)
    {

        if (id == 0|| cena == 0)
        {
            return new Tuple<bool, string>(false, "Popuni sva polja!");
        }
        else if (read.GetClanarina(id) != null)
        {
            return new Tuple<bool, string>(false, $"Clanarina sa nazivom {id} postoji!");
        }
        else
        {
            using (BibliotekaDBContainer db = new BibliotekaDBContainer())
            {
                Clanarina clanarina = new Clanarina()
                {
                    ID_Clanarine = id,
                    Cena= cena
                };

                db.Clanarinas.Add(clanarina);
                db.SaveChanges();
                return new Tuple<bool, string>(true, $"Dodata clanarina pod nazivom -  {id} ");
            }
        }
    }
        public Tuple<bool, string> AddIzdanje(short id, short  idknj, short idizd)
        {

            if (id == 0 || idknj == 0 || idizd == 0)
            {
                return new Tuple<bool, string>(false, "Popuni sva polja!");
            }
            else if (read.GetIzdanje(id) != null)
            {
                return new Tuple<bool, string>(false, $"Izdanje sa rednim brojem {id} postoji!");
            }
            else
            {
                using (BibliotekaDBContainer db = new BibliotekaDBContainer())
                {
                    Izdanje izdanje = new Izdanje()
                    {
                        Rbr_Izdanja = id,
                        KnjigaID_Knjige = idknj,
                        IzdavacID_Izdavaca = idizd
                    };

                    db.Izdanjes.Add(izdanje);
                    db.SaveChanges();
                    return new Tuple<bool, string>(true, $"Dodato izdanje pod rednim brojem -  {id} ");
                }
            }
        }

        public Tuple<bool, string> AddIzdavac(short id, string naziv, short rbrizd)
        {

            if (id == 0|| String.IsNullOrEmpty(naziv) || rbrizd == 0)
            {
                return new Tuple<bool, string>(false, "Popuni sva polja!");
            }
            else if (read.GetIzdanje(id) != null)
            {
                return new Tuple<bool, string>(false, $"Izdavac sa IDom {id} postoji!");
            }
            else
            {
                using (BibliotekaDBContainer db = new BibliotekaDBContainer())
                {
                    Izdavac izdavac= new Izdavac()
                    {
                        ID_Izdavaca= id,
                        Naziv_Izdavaca = naziv,
                        IzdanjeRbr_Izdanja = rbrizd
                    };

                    db.Izdavacs.Add(izdavac);
                    db.SaveChanges();
                    return new Tuple<bool, string>(true, $"Dodat izdavac pod IDom -  {id} ");
                }
            }
        }
        public Tuple<bool, string> AddKnjiga(short id, string autor, string naziv, Int32 kolicina, string zanr)
        {

            if (id == 0 || String.IsNullOrEmpty(autor) || String.IsNullOrEmpty(naziv) || String.IsNullOrEmpty(zanr) || kolicina == 0)
            {
                return new Tuple<bool, string>(false, "Popuni sva polja!");
            }
            else if (read.GetIzdanje(id) != null)
            {
                return new Tuple<bool, string>(false, $"Knjiga sa IDom {id} postoji!");
            }
            else
            {
                using (BibliotekaDBContainer db = new BibliotekaDBContainer())
                {
                    Knjiga knjiga = new Knjiga()
                    {
                        ID_Knjige = id,
                        Autor= autor,
                        Naziv= naziv,
                        Kolicina = kolicina,
                        Zanr = zanr
                    };

                    db.Knjigas.Add(knjiga);
                    db.SaveChanges();
                    return new Tuple<bool, string>(true, $"Dodata knjiga pod IDom -  {id} ");
                }
            }
        }
        public Tuple<bool, string> AddOsoba(Int32 id, string ime, string prezime, string mejl, string adresa)
        {

            if (String.IsNullOrEmpty(ime) || String.IsNullOrEmpty(prezime) || String.IsNullOrEmpty(mejl) || String.IsNullOrEmpty(adresa) || id == 0)
            {
                return new Tuple<bool, string>(false, "Popuni sva polja!");
            }
            else if (read.GetOsoba(id) != null)
            {
                return new Tuple<bool, string>(false, $"Osoba sa IDom {id} postoji!");
            }
            else
            {
                using (BibliotekaDBContainer db = new BibliotekaDBContainer())
                {
                    Osoba osoba= new Osoba()
                    {
                        JMBG = id,
                        Ime =ime,
                        Prezime= prezime,
                        Mejl =mejl,
                        Adresa= adresa
                    };

                    db.Osobas.Add(osoba);
                    db.SaveChanges();
                    return new Tuple<bool, string>(true, $"Dodata osoba pod IDom -  {id} ");
                }
            }
        }
        public Tuple<bool, string> AddPrimerak(short id, short rbr)
        {

            if (id == 0 || rbr == 0 )
            {
                return new Tuple<bool, string>(false, "Popuni sva polja!");
            }
            else if (read.GetPrimerak(id) != null)
            {
                return new Tuple<bool, string>(false, $"Primerak sa IDom {id} postoji!");
            }
            else
            {
                using (BibliotekaDBContainer db = new BibliotekaDBContainer())
                {
                    Primerak primerak = new Primerak()
                    {
                        ID_Primerka = id,
                        IzdanjeRbr_Izdanja = rbr
                    };

                    db.Primeraks.Add(primerak);
                    db.SaveChanges();
                    return new Tuple<bool, string>(true, $"Dodat primerak  pod IDom -  {id} ");
                }
            }
        }

        public Tuple<bool, string> AddZaIznajmljivanje(short id, string datum)
        {

            if (id == 0 || String.IsNullOrEmpty(datum))
            {
                return new Tuple<bool, string>(false, "Popuni sva polja!");
            }
            else if (read.GetIznajmljivanje(id) != null)
            {
                return new Tuple<bool, string>(false, $"Primerak za iznajmljivanje sa IDom {id} postoji!");
            }
            else
            {
                using (BibliotekaDBContainer db = new BibliotekaDBContainer())
                {
                    Za_Iznajmljivanje izn= new Za_Iznajmljivanje()
                    {
                        PrimerakID_Primerka = id,
                        Datum_Iznajmljivanja = datum
                    };

                    db.Za_Iznajmljivanje.Add(izn);
                    db.SaveChanges();
                    return new Tuple<bool, string>(true, $"Dodat primerak  pod IDom -  {id} ");
                }
            }
        }
        public Tuple<bool, string> AddZaProdaju(short id, Int64 cena)
        {

            if (id == 0 || cena == 0)
            {
                return new Tuple<bool, string>(false, "Popuni sva polja!");
            }
            else if (read.GetProdaja(id) != null)
            {
                return new Tuple<bool, string>(false, $"Primerak za prodaju sa IDom {id} postoji!");
            }
            else
            {
                using (BibliotekaDBContainer db = new BibliotekaDBContainer())
                {
                    Za_Prodaju prodaja = new Za_Prodaju()
                    {
                        PrimerakID_Primerka = id,
                        Cena_Knjige =cena
                    };

                    db.Za_Prodaju.Add(prodaja);
                    db.SaveChanges();
                    return new Tuple<bool, string>(true, $"Dodat primerak  pod IDom -  {id} ");
                }
            }
        }
    }
}
