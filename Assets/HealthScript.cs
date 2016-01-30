using UnityEngine;
using System.Collections;

public class HealthScript : MonoBehaviour {

    public int health;
    public int maxhealth;
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
            }
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
}
