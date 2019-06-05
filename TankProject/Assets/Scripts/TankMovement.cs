using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMovement : MonoBehaviour {

	public float speed = 5;
	public float angularSpeed = 10;
	private Rigidbody rigidBody;
	public AudioClip idleAudio;
	public AudioClip drivingAudio;
	private AudioSource audio;
	public int PlayerType = 1;//玩家类型区分不同控制
	// Use this for initializationArate frame, if the MonoBehaviour is enabled.
	/// </summary>
	 /// <summary>
	/// Start is called on the frame when a script is enabled just before
	/// any of the Update methods is called the first time.
	/// </summary>
	void Start()
	{
        rigidBody = this.GetComponent<Rigidbody>();
		audio = this.GetComponent<AudioSource>();
	}
	void FixedUpdate()
	{
		float v = Input.GetAxis("VerticalPlayer" + PlayerType);
        rigidBody.velocity = transform.forward * v * speed;   
		float h = Input.GetAxis("HorizontalPlayer" + PlayerType);
		rigidBody.angularVelocity = transform.up * h * angularSpeed;
		if (Mathf.Abs(h)>=0.1 || Mathf.Abs(v) >= 0.1f){
			audio.clip = drivingAudio;
			if(audio.isPlaying == false){
                audio.Play();
			}
			
		}else{
			audio.clip = idleAudio;
            if (audio.isPlaying == false)
            {
				audio.Play();
			}
		}
	}
}
