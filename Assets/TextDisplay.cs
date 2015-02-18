using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextDisplay : MonoBehaviour {

	public GameObject Sled;
	public GameObject Gift;
	
	// Use this for initialization
	void Start () {
		Sled = GameObject.Find("Sled");
		Gift = GameObject.Find ("Gift");
		
	}
	
	string proximity = "Oh no!";
	
	// Update is called once per frame
	void Update () {
		float dist = Vector3.Distance(Gift.transform.position,(Sled.transform.position));

		string textBuffer = proximity;

		if ( proximity == "Oh no!") {
			textBuffer += " You've dropped a present from the sled! You'd better hurry to retrieve it before Christmas day arrives!\nPress WASD to move Santa's sled.";
		
			if ((Input.GetKeyDown (KeyCode.W))||(Input.GetKeyDown (KeyCode.S))||(Input.GetKeyDown (KeyCode.A))||(Input.GetKeyDown (KeyCode.D))) {
				proximity = "Cold...";
			}
		
		}

		if ( proximity == "Cold...") {
			textBuffer += "\nYou're not very close.";

			if ( dist < 1500 ) {
				proximity = "Warm...";
			}
		}
		
		if ( proximity == "Warm...") {
			textBuffer += "\nYou're onto something.";

			if ( dist < 1200 ) {
				proximity = "Warmer...";
			}

			if ( dist > 1500 ) {
				proximity = "Cold...";
			}
		}

		if ( proximity == "Warmer...") {
			textBuffer += "\nYou're nearly there!";

			if ( dist < 900 ) {
				proximity = "Hot...";
			}

			if ( dist > 1200 ) {
				proximity = "Warm...";
			}
		}

		if ( proximity == "Hot...") {
			textBuffer += "\nSo close!";

			if ( dist < 600 ) {
				proximity = "On fire!";
			}

			if ( dist > 900 ) {
				proximity = "Warmer...";
			}			
		}

		if ( proximity == "On fire!") {
			textBuffer += " You've found it! Press space to pick up the present!";

			if ( dist > 600 ) {
				proximity = "Hot...";
			}
			
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
