using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour {

    public Rigidbody rigidPlayer;
   // public SpriteRenderer spritePlayer;

    public float speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.D))
        {
            rigidPlayer.velocity = new Vector3(speed, 0, 0);
        //    spritePlayer.flipX = false;
        }
        if (Input.GetKey(KeyCode.A))
        {
            rigidPlayer.velocity = new Vector3(-speed, 0, 0);
        //    spritePlayer.flipX = true;
        }
	if(Input.GetKey(KeyCode.W))
			{
				rigidPlayer.velocity = new Vector3(0 , 0, speed);
			//	spritePlayer.flipY = false;
			}
	if(Input.GetKey(KeyCode.S))
			{
				rigidPlayer.velocity = new Vector3(0, 0, -speed);
			//	spritePlayer.flipY = true;
			}
		
    }
}
