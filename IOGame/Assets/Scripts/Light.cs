using UnityEngine;
using System.Collections;

public class Light : MonoBehaviour {
    public Signal previous;
    public bool turnedon;
	// Use this for initialization
	void Start () {
        turnedon = false;
	}
	
	// Update is called once per frame
	void Update () {
        turnedon = previous.getSignal();
	}
}
