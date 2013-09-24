using UnityEngine;
using System.Collections;

public class Display : MonoBehaviour {
	Texture lifeRemainingBehindTexture;
	Texture lifeRemainingTexture;
	float lifePercent;
	
	private float left;
	private float top;
	private float backgroundWidthLife;
	private float lifeWidth;
	private float height;
	private int currLife;
	private int maxLife;
	GUIStyle style = new GUIStyle();
Texture2D texture = new Texture2D(128, 128);
	// Use this for initialization
	void Start () {
		height = 12;
		top = 8;
		left = Screen.width / 2;
		backgroundWidthLife = Screen.width / 4;
		lifeWidth = lifePercent * backgroundWidthLife;
		currLife = 100;
		maxLife = 100;
	}
	
	// Update is called once per frame
	
	void Update () {
		/*Vector3 cameraMousePoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		transform.LookAt(cameraMousePoint - Camera.main.transform.position, Vector3.back);*/
		if (currLife < 0) {
			currLife = 0;
		}
		lifePercent = currLife/maxLife;
		backgroundWidthLife = Screen.width / 4;

		left = Screen.width / 2;	
		
	}
	
	void changeLife(int i) {
		currLife += i;
	}
	
	void OnGUI() {
		//Texture2D MyTexture = ArtzkillZnetTexturePack01.Fantasy.Load("Crate01_n.tga") as Texture2D;
		//GUI.color = new Color(1.0f , 0, 0);//Set color to red
		GUI.Box(new Rect(10, 10, (Screen.width /6),30), new Texture2D(100, 100), "This is health bar");
	}
}
