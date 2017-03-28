// -------------------------------------------------------------------------------------------

// Author: Colby Johnson

// Project: Glitch Garden

// Last Updated: 07/14/2016

// Credit: Learn to Code By Making Games - Ben Tristem

// Purpose: A script to manage the projectiles

// -------------------------------------------------------------------------------------------

using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {

	public float damage;
	public float speed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		transform.Translate (Vector2.right * speed * Time.deltaTime);
	
	}
	
	void OnTriggerEnter2D (Collider2D _collider) {
	
	
		Attacker attacker = _collider.gameObject.GetComponent<Attacker>(); 
		
		Health attackerHealth = _collider.gameObject.GetComponent<Health>();
		
		if (attacker && attackerHealth) {
		
			attackerHealth.DamageHealth(damage);
			
			Destroy(gameObject);
		
		}
	
	}
	
}
