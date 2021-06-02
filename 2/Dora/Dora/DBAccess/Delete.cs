using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dora.DBAccess
{
    class Delete
    {
        private Read read;


        public Delete()
        {
            read = new Read();
        }
        public void DeleteBiblioteka(Biblioteka zaBrisanje)
        { 

            using (var db = new BibliotekaDBContainer())
            {
                db.Bibliotekas.Remove(zaBrisanje);
                db.SaveChanges();
            }
        }
        public void DeleteBibliotekar(Bibliotekar zaBrisanje)
        {

            using (var db = new BibliotekaDBContainer())
            {
                db.Bibliotekars.Remove(zaBrisanje);
                db.SaveChanges();
            }
        }
        public void DeleteClan(Clan zaBrisanje)
        {

            using (var db = new BibliotekaDBContainer())
            {
                db.Clans.Remove(zaBrisanje);
                db.SaveChanges();
            }
        }
        public void DeleteClanarina(Clanarina zaBrisanje)
        {

            using (var db = new BibliotekaDBContainer())
            {
                db.Clanarinas.Remove(zaBrisanje);
                db.SaveChanges();
            }
        }
        public void DeleteIzdanje(Izdanje zaBrisanje)
        {

            using (var db = new BibliotekaDBContainer())
            {
                db.Izdanjes.Remove(zaBrisanje);
                db.SaveChanges();
            }
        }
        public void DeleteIzdavac(Izdavac zaBrisanje)
        {

            using (var db = new BibliotekaDBContainer())
            {
                db.Izdavacs.Remove(zaBrisanje);
                db.SaveChanges();
            }
        }
        public void DeleteKnjiga(Knjiga zaBrisanje)
        {

            using (var db = new BibliotekaDBContainer())
            {
                db.Knjigas.Remove(zaBrisanje);
                db.SaveChanges();
            }
        }
        public void DeleteOsoba(Osoba zaBrisanje)
        {

            using (var db = new BibliotekaDBContainer())
            {
                db.Osobas.Remove(zaBrisanje);
                db.SaveChanges();
            }
        }
        public void DeletePrimerak(Primerak zaBrisanje)
        {

            using (var db = new BibliotekaDBContainer())
            {
                db.Primeraks.Remove(zaBrisanje);
                db.SaveChanges();
            }
        }
        public void DeleteIznajmljivanje(Za_Iznajmljivanje zaBrisanje)
        {

            using (var db = new BibliotekaDBContainer())
            {
                db.Za_Iznajmljivanje.Remove(zaBrisanje);
                db.SaveChanges();
            }
        }

        public void DeleteProdaja(Za_Prodaju zaBrisanje)
        {

            using (var db = new BibliotekaDBContainer())
            {
                db.Za_Prodaju.Remove(zaBrisanje);
                db.SaveChanges();
            }
        }
    }
}
