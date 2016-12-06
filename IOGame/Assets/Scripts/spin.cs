using UnityEngine;
using System.Collections;

public class spin : MonoBehaviour {

    public float time;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(Vector3.one * Time.deltaTime * time);
	}
}
