using UnityEngine;
using System.Collections;

public class HealthBarScript : MonoBehaviour {

    float value = 1;
    public float Value
    {
        get
        {
            return value;
        }
        set
        {
            this.value = value;
            transform.localScale = new Vector3(value, transform.localScale.y, transform.localScale.z);
            if (value > 0.50)
            {
                Color C = new Color(1 - (this.value - 0.50f) * 2, 1, 0);
                GetComponent<CanvasRenderer>().SetColor(C);
            }
            else
            {
                Color C = new Color(1, 0 + (this.value) * 2, 0);
                GetComponent<CanvasRenderer>().SetColor(C);
            }
        }
    }
    void Start()
    {
        value = 1;
        Color C = new Color(0, 1, 0);
        GetComponent<CanvasRenderer>().SetColor(C);
    }
}
