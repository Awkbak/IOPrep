using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour {
    public bool signal;
    public Signal attached;
    private Renderer rend;
	// Use this for initialization
	void Start () {
        signal = false;
        rend = GetComponent<Renderer>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        { // if left button pressed...
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                PressButton();
                // the object identified by hit.transform was clicked
                // do whatever you want
            }
        }
    }
    
    void PressButton()
    {
        signal = !signal;
        if (signal) rend.material.SetColor("_SpecColor", Color.green);
        else rend.material.SetColor("_SpecColor", Color.red);
        attached.changeSignal();
    }

    void OnMouseDown()
    {
        PressButton();
    }

}
