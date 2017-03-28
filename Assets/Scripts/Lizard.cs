// -------------------------------------------------------------------------------------------

// Author: Colby Johnson

// Project: Glitch Garden

// Last Updated: 07/13/2016

// Credit: Learn to Code By Making Games - Ben Tristem

// Purpose: A script to manage the Lizard

// -------------------------------------------------------------------------------------------

using UnityEngine;
using System.Collections;

[RequireComponent (typeof(Attacker))]
public class Lizard : MonoBehaviour {

	private Animator anim;
	private Attacker attacker;
	private Health health;
	
	// Use this for initialization
	void Start () {
		
		anim = GetComponent<Animator>();
		
		attacker = GetComponent<Attacker>();
		
		health = GetComponent<Health>();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerEnter2D (Collider2D _col) {
		
		GameObject obj = _col.gameObject;
		
		if (!_col.GetComponent<Defender>()) {
			
			return;	
			
		}
			
		anim.SetBool ("isAttacking", true);
			
		attacker.Attack(obj);
		
	}
	
}
