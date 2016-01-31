using UnityEngine;
using System.Collections;

public class SlideX : MonoBehaviour {
    public float pixels;
	// Use this for initialization
    void FixedUpdate()
    {
        transform.position += new Vector3(pixels, 0, 0);
    }
}
