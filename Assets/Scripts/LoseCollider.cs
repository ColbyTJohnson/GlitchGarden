// -------------------------------------------------------------------------------------------

// Author: Colby Johnson

// Project: Glitch Garden

// Last Updated: 07/15/2016

// Credit: Learn to Code By Making Games - Ben Tristem

// Purpose: A script to manage the collider that triggers losing the game

// -------------------------------------------------------------------------------------------

using UnityEngine;
using System.Collections;

public class LoseCollider : MonoBehaviour {

	private LevelManager levelManager;

	// Use this for initialization
	void Start () {
	
		levelManager = GameObject.FindObjectOfType<LevelManager>();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter2D () {
	
		levelManager.LoadLevel("03b Lose");
	
	}
	
}
