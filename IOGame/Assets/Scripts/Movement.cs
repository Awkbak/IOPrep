using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

    public GameObject obj;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        obj.transform.Translate(new Vector3(.1f, 0, 0));
	}
}
