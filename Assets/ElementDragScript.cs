using UnityEngine;
using System.Collections;
using System;

public class ElementDragScript : MonoBehaviour
{
    private Vector3 screenPoint;
    private Vector3 offset;
    private Vector3 original;  //could be used to store where it starts from
    bool inpenta = false;
    void OnMouseDown()
    {
        if (!inpenta)
        {
            original = gameObject.transform.position;
        }
        screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
        offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
    }
    void OnMouseDrag()
    {
        Vector3 cursorPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        Vector3 cursorPosition = Camera.main.ScreenToWorldPoint(cursorPoint) + offset;
        transform.position = cursorPosition;
    }
    void OnMouseUp()
    {
        float dist = (float)Math.Sqrt(Math.Pow((transform.position.x - 0.03f), 2) + Math.Pow((transform.position.y - (-4f)), 2));
        if (dist < 1.25)
        {
            //stuff
            inpenta = true;
        }
        else
        {
            inpenta = false;
            Reset();
        }
    }
    void Reset()
    {
        transform.position = original;
    }
}
