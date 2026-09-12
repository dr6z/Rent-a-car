using System;

namespace rentcar
{
    public class Car
    {
        public int CarID { get; set; }          // ID auta iz baze
        public string Model { get; set; }       // Model auta
        public int Year { get; set; }           // Godina proizvodnje
        public string Type { get; set; }        // Tip (SUV, Sedan, Hatchback...)
        public decimal PricePerDay { get; set; } // Cijena po danu
        public string ImagePath { get; set; }   // Putanja do slike
        public bool IsAvailable { get; set; }   // Da li je auto slobodan

        // Konstruktor
        public Car(int carID, string model, int year, string type, decimal pricePerDay, string imagePath, bool isAvailable)
        {
            CarID = carID;
            Model = model;
            Year = year;
            Type = type;
            PricePerDay = pricePerDay;
            ImagePath = imagePath;
            IsAvailable = isAvailable;
        }

        // Metoda za prikaz auta
        public string GetCarInfo()
        {
            string dostupnost = IsAvailable ? "Dostupan" : "Iznajmljen";
            return $"{CarID}: {Model} ({Year}) - {Type}, {PricePerDay}€/dan, Status: {dostupnost}";
        }
    }
}
