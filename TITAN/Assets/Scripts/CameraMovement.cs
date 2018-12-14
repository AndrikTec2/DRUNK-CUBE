 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {
    //public GameObject player;
	//private Vector3 Distance;
	float headTurnSpeed = 1f;
	// Use this for initialization

 void Update(){

	float headTurnHorizontal = Input.GetAxis("Mouse X") * headTurnSpeed;
	float headTurnVertical = Input.GetAxis("Mouse Y") * headTurnSpeed;
	transform.rotation *= Quaternion.Euler(new Vector3(0, headTurnHorizontal, 0)); 
	//turn the entire object left/right 
	//cameraHead.rotation *= Quaternion.Euler(new Vector3(-headTurnVertical, 0, 0));
	//only turn the camera up/down	
	}
}

