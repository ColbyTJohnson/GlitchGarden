// -------------------------------------------------------------------------------------------

// Author: Colby Johnson

// Project: Glitch Garden

// Last Updated: 07/13/2016

// Credit: Learn to Code By Making Games - Ben Tristem

// Purpose: A script to manage the Fox

// -------------------------------------------------------------------------------------------

using UnityEngine;
using System.Collections;

[RequireComponent (typeof(Attacker))]
public class Fox : MonoBehaviour {

	private Animator anim;
	private Attacker attacker;

	// Use this for initialization
	void Start () {
	
		anim = GetComponent<Animator>();
		
		attacker = GetComponent<Attacker>();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter2D (Collider2D _col) {
		
		GameObject obj = _col.gameObject;
		
		if (!_col.GetComponent<Defender>()) {
		
			return;	
		
		}
		
		if (_col.GetComponent<Stone>()) {
		
			anim.SetTrigger ("JumpTrigger");
		
		} else {
		
			anim.SetBool ("isAttacking", true);
		
			attacker.Attack(obj);
		
		}
	
	}
	
}
