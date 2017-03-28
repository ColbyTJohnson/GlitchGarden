// -------------------------------------------------------------------------------------------

// Author: Colby Johnson

// Project: Glitch Garden

// Last Updated: 07/11/2016

// Credit: Learn to Code By Making Games - Ben Tristem

// Purpose: A script to manage the defenders

// -------------------------------------------------------------------------------------------

using UnityEngine;
using System.Collections;

public class Defender : MonoBehaviour {

	public int starCost = 50;

	private StarDisplay starDisplay;

	// Use this for initialization
	void Start () {
	
		starDisplay = GameObject.FindObjectOfType<StarDisplay>();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	

	}
	
	public void AddStars (int _amount) {
	
		starDisplay.AddStars (_amount);
	
	}
	
}
