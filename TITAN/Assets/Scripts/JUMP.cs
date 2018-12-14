using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JUMP : MonoBehaviour {

	// Use this for initialization

public Rigidbody rb;
    public float jumpAmount;
    public float forceAmount;	void Start () {
		
	}
	
	// Update is called once per frame

	void Update () { Debug.Log(rb.velocity);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Jump");
            rb.AddForce(new Vector3(0, jumpAmount, 0), ForceMode.Impulse);
        }

		
	}
}
