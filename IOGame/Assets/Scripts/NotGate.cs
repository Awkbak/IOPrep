using UnityEngine;
using System.Collections;

public class NotGate : MonoBehaviour {
    public Signal in1;
    public Signal output;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (in1.getSignal() == output.getSignal()){
            output.changeSignal();
        }
	}
}
