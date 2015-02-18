using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		// move forward if I press W
		if ( Input.GetKey (KeyCode.W) ) {
			//Time.deltaTime is the fraction of a second in between a frame
			//a value that gets bigger with low FPS, smaller with high FPS
			transform.position += new Vector3 (0f, 0f, 10f) * (Time.deltaTime*10);
		}
		
		// FRAMERATE-DEPENDENT BEHAVIOR
		//If I have more FPS, I go faster
		
		// FRATERATE-INDEPENDENT BEHAVIOR
		// no matter what your framerate, you get the same behavior
		// movement should be framerate-independent
		
		// move backward if I press S
		if ( Input.GetKey (KeyCode.S) ) {
			transform.position += new Vector3 (0f, 0f, -10f) * (Time.deltaTime*10);
		}
		
		// move left if I press A
		if ( Input.GetKey (KeyCode.A) ) {
			transform.position += new Vector3 (-10f, 0f, 0f) * (Time.deltaTime*10);
		}
		
		// move right if I press D
		if ( Input.GetKey (KeyCode.D) ) {
			transform.position += new Vector3 (10f, 0f, 0f) * (Time.deltaTime*10);
		}
		
	}
}
