// -------------------------------------------------------------------------------------------

// Author: Colby Johnson

// Project: Glitch Garden

// Last Updated: 07/15/2016

// Credit: Learn to Code By Making Games - Ben Tristem

// Purpose: A script to manage the starcount display

// -------------------------------------------------------------------------------------------

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class StarDisplay : MonoBehaviour {

	public enum Status {SUCCESS, FAILURE};

	public int currentStars = 100;
	private Text starCountText;

	// Use this for initialization
	void Start () {
	
		starCountText = GetComponent<Text>();
		
		UpdateDisplay();
	
	}

	void UpdateDisplay () {
	
		starCountText.text = currentStars.ToString();
	
	}
	
	public void AddStars (int _amount) {
	
		currentStars += _amount;
		UpdateDisplay();
		
	}
	
	public Status UseStars (int _amount) {
	
		if (currentStars >= _amount) {
			
			currentStars -= _amount;
			UpdateDisplay();
			return Status.SUCCESS;
			
		}
		
		return Status.FAILURE;
			
	}
	
}
