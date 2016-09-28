using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour {
    private bool signal;
    public Signal attached;
	// Use this for initialization
	void Start () {
        signal = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    
    void PressButton()
    {
        attached.changeSignal();
    }
}
