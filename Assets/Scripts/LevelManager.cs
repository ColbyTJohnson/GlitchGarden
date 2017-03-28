// -------------------------------------------------------------------------------------------

// Author: Colby Johnson

// Project: Glitch Garden

// Last Updated: 07/07/2016

// Credit: Learn to Code By Making Games - Ben Tristem

// Purpose: A script to manage the levels

// -------------------------------------------------------------------------------------------

using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	[Range(0.0f, 10.0f)]
	[SerializeField]
	public float autoLoadNextLevelAfter;
	
	void Start () {
	
		if (autoLoadNextLevelAfter == 0) {
		
			Debug.Log ("No auto load");
		
		} else {
	
			Invoke ("LoadNextLevel", autoLoadNextLevelAfter);
			
		}
	
	}

	public void LoadLevel (string name) {
	
		Debug.Log ("New Level load: " + name);
		Application.LoadLevel (name);
	
	}

	public void QuitRequest () {
	
		Debug.Log ("Quit requested");
		Application.Quit ();
	
	}
	
	public void LoadNextLevel () {
	
		Debug.Log ("Loading next level");
		
		Application.LoadLevel(Application.loadedLevel + 1);	
	
	}

}
