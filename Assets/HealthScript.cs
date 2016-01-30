using UnityEngine;
using System.Collections;

public class HealthScript : MonoBehaviour {

    public int health;
    public int maxhealth;
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
        }
    }
}
