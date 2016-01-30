using UnityEngine;
using System.Collections;

public class ElementDragScript : MonoBehaviour {
    private Vector3 screenPoint;
    private Vector3 offset;
	//private Vector3 original;  //could be used to store where it starts from
    void OnMouseDown()
    {
        screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
        offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
		//original = offset;
    }
    void OnMouseDrag()
    {
        Vector3 cursorPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        Vector3 cursorPosition = Camera.main.ScreenToWorldPoint(cursorPoint) + offset;
        transform.position = cursorPosition;
    }

	void Reset()
	{
		//offset = original;
	}
}
