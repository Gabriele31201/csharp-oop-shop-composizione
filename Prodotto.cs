using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop_composizione
{
    public class Product
    {
        // ATTRIBUTI

        private int randomNumber;
        private int code;
        private string name;
        private string description;
        private float price;
        private double ivaPrice;
        private string codeName;




        // COSTRUTTORE
        public Product(string name, string description, int code)
        {
            this.name = name;
            this.code = code + randomNumber;
            this.description = description;
            price = 16.39f;
            ivaPrice = (price * 0.22f) + price;
            codeName = code + name;

        }



        // METODI   


        public int getRandomCode()
        {

            return code;
        }


        public int getRandomNumber()
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next(1, 9);

            return randomNumber;
        }



        public string getName()
        {
            return name;
        }

        public string getDescription()
        {
            return "DESCRIZIONE PRODOTTO: " + description;

        }

        public float getPrice()
        {
            return price;
        }


        public double getIvaPrice()
        {
            return ivaPrice = Math.Round(ivaPrice, 2);
        }

        public string getCodeName()
        {
            return codeName;
        }

        public string GetProdottiStringa()
        {
            string rapprStringa = "Nome: " + this.name;
            rapprStringa += "descrizione: " + this.description;
            rapprStringa += "codice: " + this.code;
            
​
            return rapprStringa;
        }



    }

}
