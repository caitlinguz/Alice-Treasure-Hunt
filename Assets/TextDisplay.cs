using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextDisplay : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	string proximity = "Oh no!";
	
	// Update is called once per frame
	void Update () {

		string textBuffer = proximity;

		if ( proximity == "Oh no!") {
			textBuffer += " You've dropped a present from the sled! You'd better hurry to retrieve it before Christmas day arrives!\nPress WASD to move Santa's sled.";
		
			if ((Input.GetKeyDown (KeyCode.W))||(Input.GetKeyDown (KeyCode.S))||(Input.GetKeyDown (KeyCode.A))||(Input.GetKeyDown (KeyCode.D))) {
				proximity = "Cold...";
			}
		
		}

		if ( proximity == "Cold...") {
			textBuffer += "\nYou're not very close.";
		}

		if ( proximity == "Warm...") {
			textBuffer += "\nYou're onto something.";
		}

		if ( proximity == "Warmer...") {
			textBuffer += "\nYou're nearly there!";
		}

		if ( proximity == "Hot...") {
			textBuffer += "\nSo close!";
		}

		if ( proximity == "On fire!") {
			textBuffer += "\nYou've found it! Press space to pick up the present!";

			if (Input.GetKeyDown (KeyCode.Space)) {
				proximity = "You win!";
			}
		}

		if ( proximity == "You win!") {
			textBuffer += "\nYay";
		}
		
		//
		
		GetComponent<Text>().text = textBuffer;
	}
}
