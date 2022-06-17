using System;

public class Elektromobil : Vozidlo
{
	int dobaNabijeni;
    public Elektromobil(string spz, int dobaNabijeni) : base(spz)
    {
        this.dobaNabijeni = dobaNabijeni;
        this.typVozidla = CarType.elektro;
    }
}
