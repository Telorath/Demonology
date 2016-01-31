using UnityEngine;
using System.Collections;
using System.Timers;

public class BattleScript : MonoBehaviour
{
    //A list of references needed for the script to function properly.
    public GameObject Player;
    public GameObject Enemy;
    public GameObject Pentagram;
    public GameObject Timer;
    public GameObject Fireball;
    public GameObject Icicle;
    public GameObject GroundSpike;
    public GameObject LightningStrike;
    public GameObject MagicMissile;
    //Called when the turn procs and handles enemy and player turns.
    public void Turn()
    {
        /*Calls the player attack as a coroutine, 
        allowing it to be stretched over multiple frames.
        This allows the turn to wait for animations.*/
        StartCoroutine(PlayerAttack());
        //If the enemy is alive, have it attack.
        if (Enemy.GetComponent<HealthScript>().Alive)
            EnemyAttack();
    }
    public IEnumerator PlayerAttack()
    {
        //Get Pentagram's PentAddE script returns a string with the name of the attack.
        string s = Pentagram.GetComponent<PentAddE>().Cast();
        if (string.Compare(s, "Heal",true) == 0)
        {
            //Fuck the attack, heal instead.
            //Put a heal function in here.
            yield break;
        }
        int damage;
        if (string.Compare(s, "Melee", true) == 0)
        {
//Sets the damage for the melee. Should be changed based on the player's "level" or "enemies beaten"
            damage = 25;
        }
else
        {
            //Base damage for spells is 25, if the player isn't meleeing they're using a spell
            damage = 25;
        }
        if (string.Compare(s,"Icicle",true) == 0)
        {
            //If the enemy is an imp icicle does double damage
            if (Enemy.name.Contains("Imp"))
            {
                damage *= 2;
            }
        }
        if (string.Compare(s, "Lightning", true) == 0)
        {
            //Show the Lightning animation
            LightningStrike.SetActive(true);
            //Loop for x frames
            for (int i = 0; i < 45; i++)
            {
                //Hold for one frame
                yield return null;
            }
            //Hide the lightning animation
            LightningStrike.SetActive(false);
            //If the enemy is a succubus, Lightning does quadrouple damage
            if (Enemy.name.Contains("Succubus"))
            {
                damage *= 4;
            }
        }
        if (string.Compare(s, "Spike", true) == 0)
        {
            //Show the ground spike animation.
            GroundSpike.SetActive(true);
            //Loop for x frames
            for (int i = 0; i < 60; i++)
            {
                //Hold for one frame
                yield return null;
            }
            //Hide the lightning animation
            GroundSpike.SetActive(false);
            if (Enemy.name.Contains("Gargoyle"))
            {
                //If the enemy is a gargoyle, ground spike does sextouple damage
                damage *= 6;
            }
        }
        if (string.Compare(s, "Fireball", true) == 0)
        {
            //Show fireball animation
            Fireball.SetActive(true);
            //loop for x frames
            for (int i = 0; i < 60; i++)
            {
                //hold for one frame
                yield return null;
            }
            //Hide the fireball animation
            Fireball.SetActive(false);
            if (Enemy.name.Contains("Skeleton"))
            {
                //if enemy is a skeleton Fireball does... nonouple? whatever, 9x damage
                damage *= 9;
            }
        }
        if (string.Compare(s, "MagicMissile", true) == 0)
        {
            //Magic Missile has a base damage of 75
            damage = 75;
            if (Enemy.name.Contains("Boss"))
            {
                //If the enemy is the boss, Magic Missile does quadrouple damage.
                damage *= 4;
            }
        }
        //Check if there's a crit.
        int crit = CritCheck();
        //if crit check returns -1, deal 75% damage
        if (crit < 0)
        {
            damage = (int)(damage * 0.75);
        }
        //if crit check returns 1, deal 140% damage
        else if (crit > 0)
        {
            damage = (int)(damage * 1.4);
        }
        //if crit check returned 0, do nothing because damage is already at 100%
        DealDamagetoEnemy(damage);
        //Reset the turn timer so the next turn can happen.
        Timer.GetComponent<Timerscript>().ResetTimer();
    }
    int CritCheck()
    {
        //Get a random number between 1 and 100
        int chance = Random.Range(1, 100);
        if (chance > 75)
        {
            //Return -1 for a weaker hit that deals 75% damage
            return -1;
        }
        else if (chance > 25)
        {
            //Return 0, nothing happens
            return 0;
        }
        else
        {
            //return 1 for a stronger hit that deals 140% damage
            return 1;
        }
    }
    
    public void EnemyAttack()
    {
        Player.GetComponent<HealthScript>().Health -= Enemy.GetComponent<DamageScript>().damage;
    }
    void DealDamagetoEnemy(int damage)
    {
        Enemy.GetComponent<HealthScript>().Health -= damage;
    }
}
