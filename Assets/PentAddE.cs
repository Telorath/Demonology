using UnityEngine;
using System.Collections;

public class PentAddE : MonoBehaviour
{

	string Catalysts;		//Used to add elements using only One char
	int MaxStored = 3;		//Most elements that can be added

	//a;ijdo['a[iodngvo[is[zrofigvo[sixfiocn
	//int NumIn;
	
	void ResetCatalysts()
	{
		Catalysts.Remove(0);		//Loss what is already in
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
			Catalysts += 'A';			//Just add the 1st Letter of E
	}
	void AddFire()
	{
		if (Catalysts.Length < MaxStored)
			Catalysts += 'F';			//Just add the 1st Letter of E
	}
	void AddWater()
	{
		if (Catalysts.Length < MaxStored)
			Catalysts += 'W';			//Just add the 1st Letter of E
	}
	void AddShadow()
	{
		if (Catalysts.Length < MaxStored)
			Catalysts += 'S';			//Just add the 1st Letter of E
	}

	void Cast()
	{

	}
}
