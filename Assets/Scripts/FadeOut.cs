// -------------------------------------------------------------------------------------------

// Author: Colby Johnson

// Project: Glitch Garden

// Last Updated: 07/07/2016

// Credit: Learn to Code By Making Games - Ben Tristem

// Purpose: A script to manage the fades on UI Panels

// -------------------------------------------------------------------------------------------

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FadeOut : MonoBehaviour {
	
	public float fadeOutTime;
	
	private Image fadePanel;
	private Color currentColor = Color.clear;
	private Color fadeToColor = Color.black;
	private float timer = 0.0f;
	
	
	// Use this for initialization
	void Start () {
		
		fadePanel = GetComponent<Image>();
		
		fadePanel.color = currentColor;
		
	}
	
	// Update is called once per frame
	void Update () {
	
		timer += Time.fixedDeltaTime;
		
		if (timer > 2f) {
			
			// Fade Out
			
			fadePanel.CrossFadeColor(fadeToColor, fadeOutTime, true, true);
			
		}
		
	}
}
