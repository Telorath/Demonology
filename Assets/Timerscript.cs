using UnityEngine;
using System.Collections;

public class Timerscript : MonoBehaviour {
    public GameObject BattleObj;
    public int TimerDuration;
    public float baseyshift;
    public float incyshift;
    int ticks;
    Vector3 basescale;
    Vector3 basepos;
	// Use this for initialization
	void Start () {
        basescale = transform.localScale;
        basepos = transform.localPosition;
        transform.localScale = new Vector3(basescale.x,0,basescale.z);
        transform.localPosition = new Vector3(basepos.x, basepos.y - baseyshift, basepos.z);
	}
	void FixedUpdate()
    {
        if (TimerDuration <= 0)
        {
            return;
        }
        ticks++;
        transform.localScale += new Vector3(0, (basescale.y / TimerDuration), 0);
        transform.localPosition += new Vector3(0, incyshift, 0);
        if (ticks > TimerDuration)
        {
            transform.localScale = new Vector3(basescale.x, 0, basescale.z);
            transform.localPosition = new Vector3(basepos.x, basepos.y - baseyshift, basepos.z);
            BattleObj.GetComponent<BattleScript>().Turn();
            ticks = 0;
        }
    }
	// Update is called once per frame
	void Update () {

    }
}
