// -------------------------------------------------------------------------------------------

// Author: Colby Johnson

// Project: Glitch Garden

// Last Updated: 07/14/2016

// Credit: Learn to Code By Making Games - Ben Tristem

// Purpose: A script to manage the player's input in the playspace

// -------------------------------------------------------------------------------------------

using UnityEngine;
using System.Collections;

public class DefenderSpawner : MonoBehaviour {

	private Camera myCamera;
	
	private GameObject defenderParent;
	private StarDisplay starDisplay;
	private AudioSource audioSource;
	
	// Use this for initialization
	void Start () {
		
		myCamera = FindObjectOfType<Camera>();
		
		starDisplay = FindObjectOfType<StarDisplay>();
		
		audioSource = GetComponent<AudioSource>();
		
		defenderParent = GameObject.Find ("Defenders");
		
		if (!defenderParent) {
			
			defenderParent = new GameObject("Defenders");
			
		}
		
	}

	// Update is called once per frame
	void Update () {
	
	}
	
	void OnMouseDown () {
	
		Vector2 rawClick = CalculateWorldPointOfMouseClick();
		
		Vector2 pos = SnapToGrid(rawClick);
		
		GameObject defender = Button.selectedButton;
		
		int starCost = defender.GetComponent<Defender>().starCost;
	
		if (starDisplay.UseStars(starCost) == StarDisplay.Status.SUCCESS) {
		
			SpawnDefender (pos, defender);
	
		} else {
		
			Debug.Log ("Not enough stars!");
		
		}
	
	}
	
	void SpawnDefender (Vector2 _pos, GameObject _defender) {
	
		audioSource.Play ();
	
		GameObject newDefender = Instantiate (_defender, _pos, Quaternion.identity) as GameObject;
		
		newDefender.transform.parent = defenderParent.transform;
	
	}
	
	Vector2 SnapToGrid (Vector2 _rawMouseClick) {
	
		float newX = Mathf.RoundToInt (_rawMouseClick.x);
		float newY = Mathf.RoundToInt (_rawMouseClick.y);
		
		return new Vector2 (newX, newY);
	
	}
	
	Vector2 CalculateWorldPointOfMouseClick () {
	
		float mouseX = Input.mousePosition.x;
		float mouseY = Input.mousePosition.y;
		float distanceFromCamera = 10f;
		
		Vector3 weirdTriplet = new Vector3 (mouseX, mouseY, distanceFromCamera);
		Vector2 worldPos = myCamera.ScreenToWorldPoint(weirdTriplet);
		
		return worldPos;
	
	}
	
}
