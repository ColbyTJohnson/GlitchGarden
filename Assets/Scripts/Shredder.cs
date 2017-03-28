// -------------------------------------------------------------------------------------------

// Author: Colby Johnson

// Project: Glitch Garden

// Last Updated: 07/14/2016

// Credit: Learn to Code By Making Games - Ben Tristem

// Purpose: A script to manage the shredders to destroy the projectiles when they
//			go off-screen

// -------------------------------------------------------------------------------------------

using UnityEngine;
using System.Collections;

public class Shredder : MonoBehaviour {
	
	void OnTriggerEnter2D (Collider2D _collider) {
		
		if (_collider.GetComponent<Projectile>()) {
		
			Destroy(_collider.gameObject);
		
		}
		    
	}
	
}
