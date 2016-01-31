using UnityEngine;
using System.Collections;
using System.Timers;

public class BattleScript : MonoBehaviour
{
    public GameObject Player;
    public GameObject Enemy;
    public GameObject Pentagram;
    public GameObject Timer;
    public GameObject Fireball;
    public GameObject Icicle;
    public GameObject GroundSpike;
    public GameObject LightningStrike;
    public GameObject MagicMissile;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Turn()
    {
        StartCoroutine(PlayerAttack());
        if (Enemy.GetComponent<HealthScript>().Alive)
            EnemyAttack();
    }
    public IEnumerator PlayerAttack()
    {
        string s = Pentagram.GetComponent<PentAddE>().Cast();
        s = "Spike";
        if (string.Compare(s, "Heal",true) == 0)
        {
            //Fuck the attack, heal instead.
            //Put a heal function in here.
            yield break;
        }
        int damage;
        if (string.Compare(s, "Melee", true) == 0)
        {
            damage = 25;
        }
else
        {
            damage = 25;
        }
        if (string.Compare(s,"Icicle",true) == 0)
        {
            if (Enemy.name.Contains("Imp"))
            {
                damage *= 2;
            }
        }
        if (string.Compare(s, "Lightning", true) == 0)
        {
            LightningStrike.SetActive(true);
            for (int i = 0; i < 45; i++)
            {
                yield return null;
            }
            LightningStrike.SetActive(false);
            if (Enemy.name.Contains("Succubus"))
            {
                damage *= 4;
            }
        }
        if (string.Compare(s, "Spike", true) == 0)
        {
            GroundSpike.SetActive(true);
            for (int i = 0; i < 60; i++)
            {
                yield return null;
            }
            GroundSpike.SetActive(false);
            if (Enemy.name.Contains("Gargoyle"))
            {
                damage *= 6;
            }
        }
        if (string.Compare(s, "Fireball", true) == 0)
        {
            Fireball.SetActive(true);
            for (int i = 0; i < 60; i++)
            {
                yield return null;
            }
            Fireball.SetActive(false);
            if (Enemy.name.Contains("Skeleton"))
            {
                damage *= 9;
            }
        }
        if (string.Compare(s, "MagicMissile", true) == 0)
        {
            damage = 75;
            if (Enemy.name.Contains("Boss"))
            {
                damage *= 4;
            }
        }
        int crit = CritCheck();
        if (crit < 0)
        {
            damage = (int)(damage * 0.75);
        }
        else if (crit > 0)
        {
            damage = (int)(damage * 1.4);
        }
        DealDamagetoEnemy(damage);
        Timer.GetComponent<Timerscript>().ResetTimer();
    }
    int CritCheck()
    {
        int chance = Random.Range(1, 100);
        if (chance > 75)
        {
            return -1;
        }
        else if (chance > 25)
        {
            return 0;
        }
        else
        {
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
