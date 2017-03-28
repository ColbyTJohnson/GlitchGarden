// -------------------------------------------------------------------------------------------

// Author: Colby Johnson

// Project: Glitch Garden

// Last Updated: 07/11/2016

// Credit: Learn to Code By Making Games - Ben Tristem

// Purpose: A script to manage the attackers

// -------------------------------------------------------------------------------------------

using UnityEngine;
using System.Collections;

[RequireComponent (typeof(Rigidbody2D))]
public class Attacker : MonoBehaviour {

	public float attackDamage;
	public float averageSpawn;

	// Set in animator
	private float currentSpeed;
	
	private GameObject currentTarget;
	private Animator anim;
	private GameTimer gameTimer;

	// Use this for initialization
	void Start () {
	
		anim = GetComponent<Animator>();
		
		gameTimer = GameObject.Find ("GameTimer").GetComponent<GameTimer>();

	}
	
	// Update is called once per frame
	void Update () {
	
		if (!gameTimer.isTimeUp) {
		
			transform.Translate (-Vector2.right * currentSpeed * Time.deltaTime);
		
		}
		
		if (!currentTarget) {
		
			anim.SetBool ("isAttacking", false);
		
		}
	
	}
	
	void OnTriggerEnter2D () {
	
		Debug.Log (name + " trigger enter");
	
	}
	
	public void SetSpeed (float _speed) {
	
		currentSpeed = _speed;
	
	}
	
	// Called from animator at actual time of attack
	public void StrikeCurrentTarget (float _damage) {
	
		if (currentTarget) {
		
			Health targetHealth = currentTarget.GetComponent<Health>();
			
			if (targetHealth) {
			
				targetHealth.DamageHealth(attackDamage);
			
			}
		
		}
	
	}
	
	// Called from attacker 
	public void Attack (GameObject _obj) {
	
		currentTarget = _obj;
	
	}
	
}
