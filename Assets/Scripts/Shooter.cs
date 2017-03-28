// -------------------------------------------------------------------------------------------

// Author: Colby Johnson

// Project: Glitch Garden

// Last Updated: 07/14/2016

// Credit: Learn to Code By Making Games - Ben Tristem

// Purpose: A script to manage the shooting defenders

// -------------------------------------------------------------------------------------------

using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Defender))]
public class Shooter : MonoBehaviour {

	public GameObject projectile;
	public GameObject gun;
	
	private GameObject projectileParent;
	private Animator anim;
	private AttackerSpawner attackerSpawner;
	private GameTimer gameTimer;
	private AudioSource audioSource;

	// Use this for initialization
	void Start () {
	
		anim = GetComponent<Animator>();
		
		gameTimer = GameObject.Find ("GameTimer").GetComponent<GameTimer>();
		
		audioSource = GetComponent<AudioSource>();
	
		projectileParent = GameObject.Find ("Projectiles");
		
		if (!projectileParent) {
		
			projectileParent = new GameObject("Projectiles");
			
		}
		
		SetSpawnerLane();
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (IsAttackerAhead() && !gameTimer.isTimeUp) {
		
			anim.SetBool ("isAttacking", true);
		
		} else {
		
			anim.SetBool ("isAttacking", false);
		
		}
	
	}
	
	void SetSpawnerLane () {
	
		AttackerSpawner[] spawnerArray = GameObject.FindObjectsOfType<AttackerSpawner>();
		
		foreach (AttackerSpawner spawner in spawnerArray) {
		
			if (spawner.transform.position.y == transform.position.y) {
			
				attackerSpawner = spawner;
			
			}
		
		}
	
	}
	
	bool IsAttackerAhead () {
	
		// Exit if no attackers in lane
		if (attackerSpawner.transform.childCount <= 0) {
		
			return false;
			
		}
		
		// If attackers are in lane, are they ahead?
		foreach (Transform attacker in attackerSpawner.transform) {
		
			if (attacker.transform.position.x > transform.position.x) {
				
				return true;				
				
			}

		}
		
		// If attackers are in lane, but not ahead
		return false;
		
	}
	
	private void Fire () {
	
		audioSource.Play ();
	
		GameObject newProjectile = Instantiate (projectile) as GameObject;
		
		newProjectile.transform.parent = projectileParent.transform;
		
		newProjectile.transform.position = gun.transform.position;
	
	}
}
