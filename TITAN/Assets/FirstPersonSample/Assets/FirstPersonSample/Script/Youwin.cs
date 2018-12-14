using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Youwin : MonoBehaviour {

    //public static GameManager instance = null;

	public GameObject youWin;
	public float resetDelay;

	void Awake ()
	{
		//if (instance == null)
		//instance = this;
		//else
		//if(instance != null)
		//Destroy(GameObject);
	}
	
	
	public void win () 
	{
		youWin.SetActive (true);
		Time.timeScale = .5f;
		Invoke ("Reset", resetDelay);
	}
	void Reset() {
		Time.timeScale = 1.5f;
		//Application.LoadLevel (Application.LoadLevel);
	}
}
