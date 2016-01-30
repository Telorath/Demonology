using UnityEngine;
using System.Collections;
using System.Timers;

public class BattleScript : MonoBehaviour {
    public GameObject PlayerHealth;
    public GameObject EnemyHealth;
    public float xshift;
    float pRed = 1;
    float pBlue = 1;
    float pGreen = 1;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void Turn()
    {
        pBlue -= 0.03f;
        pGreen -= 0.03f;
        PlayerHealth.transform.localScale -= new Vector3(1, 0, 0);
        PlayerHealth.transform.localPosition -= new Vector3(xshift,0,0);
        PlayerHealth.GetComponent<SpriteRenderer>().color = new Color(pRed,pGreen,pBlue);
    }
}
