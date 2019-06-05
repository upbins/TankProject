 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankAttack : MonoBehaviour {
	private Transform firePosition;
	public GameObject shellPrefab;
    public AudioClip tankAttckAuido;
	public KeyCode firekey = KeyCode.Space;
	public int ShellSpeed = 15; 
	// Use this for initialization
	void Start () {
		firePosition = transform.Find("FirePosition");
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(firekey)){
            AudioSource.PlayClipAtPoint(tankAttckAuido, transform.position);
			GameObject go = GameObject.Instantiate(shellPrefab,firePosition.position,firePosition.rotation) as GameObject; 
			go.GetComponent<Rigidbody>().velocity = go.transform.forward*ShellSpeed;
		}
	}
}
