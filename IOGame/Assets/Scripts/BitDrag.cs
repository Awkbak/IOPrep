using UnityEngine;
using System.Collections;

public class BitDrag : MonoBehaviour {

    private Vector3 screenPoint;
    private Vector3 offset;
    private float locked_Yposition;

    public Transform gameObj;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseDown()
    {
        //screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position); // I removed this line to prevent centring 
        locked_Yposition = screenPoint.z;
        offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
        Cursor.visible = false;
    }

    void OnMouseDrag()
    {
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
        curPosition.z = locked_Yposition;
        transform.position = curPosition;
    }

    void OnMouseUp()
    {
        Cursor.visible = true;
    }

    void OnCollisionEnter(Collision collider)
    {
        if(GetComponent<Collider>().gameObject.CompareTag("Snap"))
            transform.position = gameObj.transform.position;
    }
}
