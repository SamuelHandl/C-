using System;

public class Dodavka : Vozidlo
{
	int nosnostKorby;
	public Dodavka(string spz, int nosnostKorby) : base(spz)
	{
		this.nosnostKorby = nosnostKorby;
		this.typVozidla = CarType.pickup;
	}
}
