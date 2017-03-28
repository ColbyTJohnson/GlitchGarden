// -------------------------------------------------------------------------------------------

// Author: Colby Johnson

// Project: Glitch Garden

// Last Updated: 07/14/2016

// Credit: Learn to Code By Making Games - Ben Tristem

// Purpose: A script to manage the attackers' spawns

// -------------------------------------------------------------------------------------------

using UnityEngine;
using System.Collections;

public class AttackerSpawner : MonoBehaviour {

	public float spawnTimeMin;
	public float spawnTimeMax;

	public float initialSpawnMin;
	public float initialSpawnMax;
	
	public GameObject[] attackerPrefabArray;
	
	private float timer;
	private float timeLimit;	
	private float initialTimeLimit;
	
	private GameObject attackerParent;

	// Use this for initialization
	void Start () {
	
		attackerParent = GameObject.Find ("Attackers");
		
		if (!attackerParent) {
			
			attackerParent = new GameObject("Attackers");
			
		}
		
		// Set the timeLimit for the first spawn
		initialTimeLimit = Random.Range(initialSpawnMin, initialSpawnMax);
		timeLimit = initialTimeLimit;
	
	}
	
	// Update is called once per frame
	void Update () {
	
		UpdateTimer ();
	
	}
	
	void UpdateTimer () {
	
		// Add time to the timer
		timer += Time.deltaTime;
		
		// Check to see if it's time to spawn an enemy
		if (timer >= timeLimit) {
			
			// Set the new timeLimit for the next spawn
			timeLimit = Random.Range (spawnTimeMin, spawnTimeMax);
			
			// Reset the timer to zero
			timer = 0;
			
			float enemyNum = Random.value;
			
			if (enemyNum < 0.6) {
			
				GameObject enemy = attackerPrefabArray[0];
				
				// Spawn an enemy
				Spawn(enemy);
			
			} else {
			
				GameObject enemy = attackerPrefabArray[1];
				
				// Spawn an enemy
				Spawn(enemy);
				
			}
			
		}
	
	}
	
	void Spawn (GameObject _myGameObject) {
	
		GameObject myAttacker = Instantiate (_myGameObject) as GameObject;
		
		myAttacker.transform.parent = transform;
		myAttacker.transform.position = transform.position;
	
	}
	
}
