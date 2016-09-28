using UnityEngine;
using System.Collections;

public class Signal : MonoBehaviour {

    // Use this for initialization
    private bool signal;
	void Start () {
        signal = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void changeSignal()
    {
        signal = !signal;
    }
    public bool getSignal()
    {
        return signal;
    }
}
