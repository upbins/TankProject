using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TankHealth : MonoBehaviour {
	public int Hp = 100;
	// Use this for initialization
	public GameObject tankExplosion;
	public AudioClip tankExplosionAuido;
	public Slider hpSlider;
	private int MaxHp;
	void Start () {
		MaxHp = Hp;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void DoDamage(){
		if (Hp <= 0){
			return;
		}
		Hp -= Random.Range(10,20);
		hpSlider.value = (float)Hp/MaxHp; 
		if (Hp <= 0){
			AudioSource.PlayClipAtPoint(tankExplosionAuido,transform.position);
			GameObject.Instantiate(tankExplosion,transform.position + Vector3.up,transform.rotation);
			GameObject.Destroy(this.gameObject);
		}
	}
}
