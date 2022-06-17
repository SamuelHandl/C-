using System;

public class Vozidlo
{
	protected string spz;
	protected string majitel;
	protected CarType typVozidla;
	public Vozidlo()
    {
		this.typVozidla = CarType.blocked;
    }
	public Vozidlo(string spz)
	{
		this.spz = spz; // Nově vytvořené vozidlo má validní SPZ –7 znaků, alespoň jedno písmeno a jedna číslice
		this.typVozidla = CarType.basic;
	}
	public string VypisSPZ()
    {
		return this.spz;
    }
	public CarType vratTypVozidla()
	{
		return this.typVozidla;
	}

}
public enum CarType
{
	basic = 80,
	elektro = 30,
	pickup = 100,
	blocked = 0
}