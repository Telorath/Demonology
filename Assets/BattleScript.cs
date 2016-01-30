using UnityEngine;
using System.Collections;
using System.Timers;

public class BattleScript : MonoBehaviour {
    public GameObject Player;
    public GameObject Enemy;
    public GameObject Pentagram;
    public GameObject Timer;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void Turn()
    {
        Player.GetComponent<HealthScript>().Health -= 10;
        PlayerAttack();
        Timer.GetComponent<Timerscript>().ResetTimer();
    }
    public void PlayerAttack()
    {
        string s = Pentagram.GetComponent<PentAddE>().Cast();
        if (string.Compare(s,"Melee",true) == 0)
        {
            Enemy.GetComponent<HealthScript>().Health -= 10;
        }
    }
}
