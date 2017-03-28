// -------------------------------------------------------------------------------------------

// Author: Colby Johnson

// Project: Glitch Garden

// Last Updated: 07/15/2016

// Credit: Learn to Code By Making Games - Ben Tristem

// Purpose: A script to manage the slider that indicates how much time is left in the level

// -------------------------------------------------------------------------------------------

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameTimer : MonoBehaviour {

	public float levelSeconds = 60;
	
	private Slider gameTimer;
	private AudioSource winSound;
	private LevelManager levelManager;
	private GameObject winLabel;
	
	public bool isTimeUp;
	private bool isEndOfLevel = false;

	// Use this for initialization
	void Start () {
	
		gameTimer = GetComponent<Slider>();
		
		winSound = GetComponent<AudioSource>();
		
		levelManager = GameObject.FindObjectOfType<LevelManager>();
		
		winLabel = GameObject.Find ("YouWin");
		
		winLabel.SetActive(false);
	
	}
	
	// Update is called once per frame
	void Update () {
		
		gameTimer.value = 1 - (Time.timeSinceLevelLoad/levelSeconds);
		
		isTimeUp = (Time.timeSinceLevelLoad >= levelSeconds);
		
		if (isTimeUp && !isEndOfLevel) {
			
			HandleWin ();
			
		}
	
	}

	void HandleWin () {
		
		DestroyAllTaggedObjects();
		winSound.Play ();
		winLabel.SetActive (true);
		Invoke ("LoadNextLevel", winSound.clip.length);
		isEndOfLevel = true;
	
	}
	
	void DestroyAllTaggedObjects () {
	
		GameObject[] taggedObjects = GameObject.FindGameObjectsWithTag("destroyOnWin");
		
		foreach (GameObject taggedObject in taggedObjects) {
		
			Destroy(taggedObject);
			
		}
	
	}
	
	void LoadNextLevel () {
	
		levelManager.LoadNextLevel();
	
	}
	
}
