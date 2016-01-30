using UnityEngine;
using System.Collections;
using System.Timers;

public class Timerscript : MonoBehaviour
{
    public GameObject BattleObj;
    public int TimerDuration;
    float TimeRemaining;
    void Start()
    {
        GetComponent<CanvasRenderer>().SetColor(new Color(0.8f, 0, 0.8f));
        TimeRemaining = TimerDuration;
    }
    // Update is called once per frame
    void Update()
    {
        if (TimerDuration <= 0)
        {
            return;
        }
        TimeRemaining -= Time.deltaTime;
        if (TimeRemaining <= 0)
        {
            BattleObj.GetComponent<BattleScript>().Turn();
            TimeRemaining = TimerDuration;
        }
        transform.localScale = new Vector3(((float)TimeRemaining / (float)TimerDuration), 1, 1);
    }
}
