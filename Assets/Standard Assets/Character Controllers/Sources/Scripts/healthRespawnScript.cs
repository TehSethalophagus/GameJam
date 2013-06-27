using UnityEngine;
using System.Collections;

public class healthRespawnScript : MonoBehaviour {
	
	public GameObject health;
	public GameObject pickup;
	public float respawnTimer;
	public float respawnTime;
	// Use this for initialization
	void Start () {
		pickup = Instantiate(health, this.transform.position, this.transform.rotation) as GameObject;
	}
	
	// Update is called once per frame
	void Update () {
		if(pickup == null){
			respawnTimer += Time.deltaTime;
			if(respawnTimer > 5){
				pickup = Instantiate(health, this.transform.position, this.transform.rotation) as GameObject;
				respawnTimer = 0;
			}
		}
	}
}
