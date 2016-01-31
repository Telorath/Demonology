using UnityEngine;
using System.Collections;
using System.Timers;

public class Timerscript : MonoBehaviour
{
    //Keeps track of the object with the battle script
    public GameObject BattleObj;
    //Represents the amount of time between turns
    public float TimerDuration;
//time remaining before the next turn starts
    float TimeRemaining;
    void Start()
    {
        //Sets the color of the bar
        GetComponent<CanvasRenderer>().SetColor(new Color(0.8f, 0, 0.8f));
        //Starts the timer by setting the remaining time to the duration.
        TimeRemaining = TimerDuration;
    }
    // Update is called once per frame
    void Update()
    {
        /*If the time remaining or the duration is 0, return.
        The timer is off or waiting for animations to play.*/
        if (TimeRemaining <= 0 || TimerDuration <= 0)
        {
            return;
        }
        //Reduces the time remaining by the number of milliseconds since last frame.
        TimeRemaining -= Time.deltaTime;
        //if the time ran out, start the turn
        if (TimeRemaining <= 0)
        {
            //Reset time to zero exactly.
            TimeRemaining = 0;
            //Tell the battle script to have the player and enemy take turns.
            BattleObj.GetComponent<BattleScript>().Turn();
        }
        //Adjusts the timer bar to match the remaining duration.
        transform.localScale = new Vector3(((float)TimeRemaining / (float)TimerDuration), 1, 1);
    }
    public void ResetTimer()
    {
        //Resets the timer by setting the time remaining equal to the max duration.
        TimeRemaining = TimerDuration;
    }
}
