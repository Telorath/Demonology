using UnityEngine;
using System.Collections;

public class SlideIn : MonoBehaviour {
    public float speed;
    public float finalx;
    void FixedUpdate()
    {
        if (transform.position.x > finalx)
        {
            transform.position += new Vector3(speed, 0, 0);
        }
    }
}
