using System;

namespace rentcar
{
    public class Carr
    {
        public int AutomobilID { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public int ZapreminaMotora { get; set; }
        public int Godište { get; set; }
        public string Tip { get; set; }
        public string ImagePath { get; set; }
        public bool Dostupno { get; set; }
        public decimal CijenaPoDanu { get; set; }

        // Konstruktor
        public Carr(int automobilID, string marka, string model, int zapremina, int godiste, string tip, string imagePath, bool dostupno, decimal cijena)
        {
            AutomobilID = automobilID;
            Marka = marka;
            Model = model;
            ZapreminaMotora = zapremina;
            Godište = godiste;
            Tip = tip;
            ImagePath = imagePath;
            Dostupno = dostupno;
            CijenaPoDanu = cijena;
        }

        // Metoda za prikaz auta
        public string GetCarInfo()
        {
            string dostupnost = Dostupno ? "Dostupan" : "Iznajmljen";
            return $"{AutomobilID}: {Marka} {Model} ({Godište}) - {Tip}, {CijenaPoDanu} €/dan, Status: {dostupnost}";
        }

        // Iznajmljivanje
        public bool Rent()
        {
            if (Dostupno)
            {
                Dostupno = false;
                return true;
            }
            return false;
        }

        // Vraćanje
        public void Return()
        {
            Dostupno = true;
        }

        // Ukupna cijena najma
        public decimal CalculateTotalPrice(int days)
        {
            return days * CijenaPoDanu;
        }
    }
}
