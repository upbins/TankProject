using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shell : MonoBehaviour {
	public GameObject ShellExplosionPrefab;
	// Use this for initialization
    public AudioClip tankShellAuido;
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	/// <summary>
	/// OnTriggerEnter is called when the Collider other enters the trigger.
	/// </summary>
	/// <param name="other">The other Collider involved in this collision.</param>
	void OnTriggerEnter(Collider other)
	{
        AudioSource.PlayClipAtPoint(tankShellAuido, transform.position);
		GameObject.Instantiate(ShellExplosionPrefab,transform.position,transform.rotation); 
		GameObject.Destroy(this.gameObject);
		if (other.tag == "Tank"){
			other.SendMessage("DoDamage");
		}
	}
}
