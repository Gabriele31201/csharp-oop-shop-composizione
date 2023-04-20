using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop_composizione
{
   public class Negozio
    {
        // ATTRIBUTI
        private string nome;
        private string citta;
        private string indirizzo;
        private int numeroCivico;
        private List<Product> prodotti;

        // COSTRUTTORE

        public Negozio(string nome, string citta, string indirizzo, int numeroCivico) 
        {
            this.nome = nome;
            this.citta = citta;
            this.indirizzo = indirizzo;
            this.numeroCivico = numeroCivico;
            this.prodotti = new List<Product>();


        }

        //GETTERS

        public string getNome() 
        { 
            return nome;
        }

        public string getCitta()
        {
            return citta;
        }

        public int getNumeroCivico()
        {
            return numeroCivico;
        }

        public string getIndirizzo() 
        { 
            return indirizzo;
        }

        public List<Product> getListaProdotti()
        {
            return prodotti;
        }


        // SETTERS

            public void setNome(string nome)
        {
            this.nome = nome;
        }

            public void setIndirizzo (string indirizzo)
        {
            this.indirizzo = indirizzo;
        }

            public void setCivico (int numeroCivico)
        {
            this.numeroCivico = numeroCivico;
        }


        // METODI

        public void aggiungiprodotto(Product nuovoProdotto)
        {
            prodotti.Add(nuovoProdotto);
        }


        public string rappresentaInStringa()
        {
            string rapprStringa = "nome: " + this.nome + "\n";
            rapprStringa += "citta: " + this.citta + "\n";
            rapprStringa += "indirizzo: " + this.indirizzo + "\n";
            rapprStringa += "prodotti: \n";
​
            foreach (Product prodottoScansionato in prodotti)
            {
                rapprStringa += " - " + prodottoScansionato.GetProdottiStringa() + "\n";
            }
​
            rapprStringa += "\n";
​
            return rapprStringa;
        }

    }
}
