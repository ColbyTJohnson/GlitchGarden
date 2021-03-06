﻿// -------------------------------------------------------------------------------------------

// Author: Colby Johnson

// Project: Glitch Garden

// Last Updated: 07/07/2016

// Credit: Learn to Code By Making Games - Ben Tristem

// Purpose: A script to manage the music throughout the levels

// -------------------------------------------------------------------------------------------

using UnityEngine;
using System.Collections;

public class MusicManager : MonoBehaviour {

	public AudioClip[] levelMusicChange;
	
	private AudioSource audioSource;

	void Awake () {
	
		DontDestroyOnLoad (gameObject);
	
	}
	
	void Start () {
	
		audioSource = GetComponent<AudioSource>();
		
		PlayerPrefsManager.SetMasterVolume(.75f);
		
		audioSource.volume = PlayerPrefsManager.GetMasterVolume();	
	
	}
	
	void OnLevelWasLoaded (int _level) {
	
		AudioClip thisLevelMusic = levelMusicChange[_level];
	
		Debug.Log ("Music playing for level: " + thisLevelMusic);
	
		if (thisLevelMusic) {
		
			audioSource.clip = thisLevelMusic;
			
			audioSource.Play();
		
		}
	
	}
	
	public void ChangeVolume (float _volume) {
	
		audioSource.volume = _volume;
	
	}
	
}
