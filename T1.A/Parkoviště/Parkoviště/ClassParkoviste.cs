using System;

public class Parkoviste
{
	int kapacita;
	int prijem = 0;
	Vozidlo[] parkovaciMista;
	public Parkoviste(int k)
	{
		this.parkovaciMista = new Vozidlo[k];
		this.kapacita = k;
	}
	// Jednotlivé funkce, které poskytuje třída parkoviště, budou volány skrze tlačítka ve formuláři

	public string VypisVozidel() 
    {
		string vozidla = "";
		foreach(Vozidlo vozidlo in this.parkovaciMista)
        {
			if (vozidlo != null)
            {
				vozidla += vozidlo.VypisSPZ() + ",";
            }	
        }
		return vozidla;
    }
	public bool JeMistoObsazene(int misto)
	{
		bool jeMistoObsazene = false;
        if(this.ZkontrolujCisloMista(misto))
        {
			jeMistoObsazene = this.parkovaciMista[misto] != null;
		}
		return jeMistoObsazene;
    }
	public void ZablokujMisto(int misto)
    {
        if(! this.JeMistoObsazene(misto))
		{
			this.parkovaciMista[misto] = new Vozidlo();
        }
    }
	public void OdblokujMisto(int misto)
    {

    }
	public int Obsazenost()
    {
		int obsazenaMista = 0;
		foreach (Vozidlo vozidlo in this.parkovaciMista)
		{
			if (vozidlo != null)
			{
				obsazenaMista++;
			}
		}
		return obsazenaMista;
    }
	public int[] ZobrazVolnaMista()
    {
		int[] volnaMista = new int[this.kapacita];
		int j = 0;
		for (int i = 0; i < this.kapacita; i++)
        {
			if (this.parkovaciMista[i] == null)
			{
				volnaMista[j++] = i;
			}
        }
		return volnaMista;
    }
	public int PrijemZParkovani()
    {
		return this.prijem;
    }
	public bool Zaparkuj(Vozidlo vozidlo)
    {
		int volnyMisto = -1;
		//Potřebujeme zaparkovat auto na první volné místo
		// prvně najdeme volné místo pokud je/není
		for (int misto = 0; misto < this.kapacita; misto++)
		{
			Vozidlo zaparkovaneVozidlo = this.parkovaciMista[misto];
			if (zaparkovaneVozidlo == null)
			{
				volnyMisto = misto;
				continue; // TODO: zjistit jak ukončit cyklus
			}
		}
		return this.Zaparkuj(vozidlo, volnyMisto);
    }
	public bool Zaparkuj(Vozidlo vozidlo, int misto)
    {
		if (! this.JeMistoObsazene(misto))
        {
			this.parkovaciMista[misto] = vozidlo;
			this.prijem += (int)vozidlo.vratTypVozidla();
			return true;
		}
        else
		{
			return false;
		}
    }
	public bool Vyparkuj(Vozidlo vozidlo)
    {
		if (vozidlo != null)
		{
			for(int misto = 0; misto < this.kapacita; misto++)
			{
				Vozidlo zaparkovaneVozidlo = this.parkovaciMista[misto];
				if (zaparkovaneVozidlo != null && zaparkovaneVozidlo == vozidlo)
                {
					return this.Vyparkuj(misto, false);
                }
			}
			return false;
		}
		else
		{
			return false;
		}
    }
	public bool Vyparkuj(int misto)
    {
		return this.Vyparkuj(misto, true);
    }

	private bool Vyparkuj(int misto, bool zkontrolujMisto)
    {
		bool jeMistoValidni = true;
		if (zkontrolujMisto)
        {
			jeMistoValidni = this.ZkontrolujCisloMista(misto);
		}

		if (jeMistoValidni && this.JeMistoObsazene(misto))
		{
			this.parkovaciMista[misto] = null;
			return true;
		}
		else
		{
			return false;
		}
	}

	/** Vrati TRUE v pripade ze zadane cislo mista existuje, tzn je validni. */
	private bool ZkontrolujCisloMista(int misto)
    {
		if (misto > this.kapacita - 1 || misto < 0)
		{
			// TODO: Vypis chybu do konzole
			return false;
		}
		else
		{
			return true;
		}
	}
}
