using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour {
    private bool signal = false;
	// Use this for initialization
	void Start () {
        signal = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    
    void PressButton()
    {
        signal = !signal;
    }
}
