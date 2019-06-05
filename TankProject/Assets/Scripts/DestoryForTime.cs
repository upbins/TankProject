using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryForTime : MonoBehaviour {

	// Use this for initialization
	public float time = 1.5f;
	void Start () {
		Destroy(this.gameObject,time);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
