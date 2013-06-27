using UnityEngine;
using System.Collections;

public class armorRespawnScript : MonoBehaviour {
	
	public GameObject armor;
	public GameObject pickup;
	public float respawnTimer;
	public float respawnTime;
	// Use this for initialization
	void Start () {
		pickup = Instantiate(armor, this.transform.position, this.transform.rotation) as GameObject;
	}
	
	// Update is called once per frame
	void Update () {
		if(pickup == null){
			respawnTimer += Time.deltaTime;
			if(respawnTimer > respawnTime){
				pickup = Instantiate(armor, this.transform.position, this.transform.rotation) as GameObject;
				respawnTimer = 0;
			}
		}
	}
}
