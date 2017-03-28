
// Author: Colby Johnson

// Project: Glitch Garden

// Last Updated: 07/14/2016

// Credit: Learn to Code By Making Games - Ben Tristem

// Purpose: A script to manage the buttons to place defenders

// -------------------------------------------------------------------------------------------

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Button : MonoBehaviour {

	public GameObject defenderPrefab;
	public static GameObject selectedButton;
	
	private Button[] buttonArray;
	private Text costText;
	private AudioSource audioSource;
	
	// Use this for initialization
	void Start () {
	
		buttonArray = GameObject.FindObjectsOfType<Button>();
		
		costText = GetComponentInChildren<Text>();
		
		audioSource = GetComponent<AudioSource>();
		
		costText.text = defenderPrefab.GetComponent<Defender>().starCost.ToString();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnMouseDown () {
	
		foreach (Button thisButton in buttonArray) {
		
			thisButton.GetComponent<SpriteRenderer>().color = Color.black;
		
		}			
		
		GetComponent<SpriteRenderer>().color = Color.white;
		
		audioSource.Play();
		
		selectedButton = defenderPrefab;
	
	}
	
}
