using UnityEngine;
using System.Collections;

public class HealthScript : MonoBehaviour {

    public int health;
    public int maxhealth;
    public GameObject HealthBar;
    bool alive = true;
    public int Health
    {
        get
        {
            return health;
        }
        set
        {
            health = value;
            if (health > maxhealth)
            {
                health = maxhealth;
            }
            if (health <= 0)
            {
                alive = false;
                health = 0;
            }
            HealthBar.GetComponentInChildren<HealthBarScript>().Value = ((float)health / maxhealth);
        }
    }
    public int MaxHealth
    {
        get
        {
            return maxhealth;
        }
        set
        {
            maxhealth = value;
        }
    }
    public bool Alive
    {
        get { return alive; }
    }
}
