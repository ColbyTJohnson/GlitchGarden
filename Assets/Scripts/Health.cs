// -------------------------------------------------------------------------------------------

// Author: Colby Johnson

// Project: Glitch Garden

// Last Updated: 07/14/2016

// Credit: Learn to Code By Making Games - Ben Tristem

// Purpose: A script to manage health

// -------------------------------------------------------------------------------------------

using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {

	public float health;
	
	private Animator anim;
	
	void Start () {
	
		anim = GetComponent<Animator>();
	
	}
	
	public void DamageHealth (float _damage) {
	
		health -= _damage;
		
		if (health <= 0) {
			
			anim.SetBool("isDying", true);
			
			if (!anim.GetBool ("isDying")) {
			
				Destruction();
			
			}
			
		}
	
	}
	
	public void Destruction () {
		
		Destroy(gameObject);
	
	}
	
}
