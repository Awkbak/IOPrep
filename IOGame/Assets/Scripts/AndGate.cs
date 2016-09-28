using UnityEngine;
using System.Collections;

public class AndGate : MonoBehaviour {
    public Signal in1;
    public Signal in2;
    public Signal output;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	    if(in1.getSignal() == in2.getSignal())
        {
            if(!output.getSignal())
            output.changeSignal();
        }else
        {
            if (output.getSignal())
            output.changeSignal();
        }
	}
}
