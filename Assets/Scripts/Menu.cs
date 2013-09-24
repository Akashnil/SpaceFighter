
using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {

	void OnGUI () {
		// Make the Pause/Resume button. If it is pressed, timeScale will be changed
		if(GUI.Button(new Rect(20,90,60,20), "|| | >>")) {
			if (Time.timeScale == 1) { Time.timeScale = 0; // stop the game
			}
			else { Time.timeScale = 1; // resume the game
			}
		}

	}
}