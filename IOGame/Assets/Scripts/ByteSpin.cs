using UnityEngine;
using System.Collections;

public class ByteSpin : MonoBehaviour {

    public GameObject center;
    public float speed;

    public bool truth;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {

        if (truth)
        {
            transform.Rotate(Vector3.one, speed * Time.deltaTime);
            transform.RotateAround(center.transform.position, Vector3.right, speed * Time.deltaTime);
        }
        else
        {
            transform.Rotate(Vector3.one, speed * Time.deltaTime);
            transform.RotateAround(center.transform.position, Vector3.up, speed * Time.deltaTime);
        }
        
	}

}
