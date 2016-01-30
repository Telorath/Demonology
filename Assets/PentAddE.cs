using UnityEngine;
using System.Collections;

public class PentAddE : MonoBehaviour
{

	string Catalysts;		//Used to add elements using only One char
	int MaxStored = 3;		//Most elements that can be added
	
	//int NumIn;
	
	void ResetCatalysts()
	{
		Catalysts.Remove(0);		//Loss what is already in
									//Just as we wanted it
	}

	// Use this for initialization
	void Start () 
	{
		//NumIn = 0;
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	void AddEarth()
	{
		if (Catalysts.Length < MaxStored)
			Catalysts += 'E';			//Just add the 1st Letter of E
		
	}
	void AddAir()
	{
		if (Catalysts.Length < MaxStored)
			Catalysts += 'A';			//Just add the 1st Letter of A
	}
	void AddFire()
	{
		if (Catalysts.Length < MaxStored)
			Catalysts += 'F';			//Just add the 1st Letter of F
	}
	void AddWater()
	{
		if (Catalysts.Length < MaxStored)
			Catalysts += 'W';			//Just add the 1st Letter of W
	}
	void AddShadow()
	{
		if (Catalysts.Length < MaxStored)
			Catalysts += 'S';			//Just add the 1st Letter of S
	}

	string Cast()
	{
		// Icicle
		if(Catalysts == "AW" || Catalysts == "WA")
		{
			string Icicle = "Icicle";
			ResetCatalysts();
			return Icicle;
		}
		// Lightning Strike
		if (Catalysts == "EA" || Catalysts == "AE")
		{
			string Lightning = "Lightning";
			ResetCatalysts();
			return Lightning;
		}
		// Ground spike
		if (Catalysts == "ES" || Catalysts == "SE")
		{
			string Spike = "Spike";
			ResetCatalysts();
			return Spike;
		}
		// Fireball
		if (Catalysts == "FS" || Catalysts == "SF")
		{
			string Fireball = "Fireball";
			ResetCatalysts();
			return Fireball;
		}
		// Magic Missile
		if (Catalysts.Contains("SFA"))
		{
			string MagicMissile = "MagicMissile";
			ResetCatalysts();
			return MagicMissile;
		}
		else
			return "Melee";
	}
}
