
using UnityEngine;
using System.Collections;

public class energyBar : MonoBehaviour {
	public int currValue;
	public int maxValue;

	public Vector2 pos ;
	public Vector2 size ;
	public Texture2D progressBarEmpty;// = new Texture2D(100, 30);
	public Texture2D progressBarFull;// = new Texture2D(100, 30);

	public float percent;
	public float barWidth;
	public int maxBarWidth;
	public int left;
	public int top;

	// Use this for initialization
	void Start () {
		//this.top = top;
		pos = new Vector2(20,40);
		size = new Vector2(60,10);
		top = 8;
		left = 8;
		maxBarWidth = 100;
		currValue = 50;
		maxValue = 100;
		percent = ((float)currValue)/maxValue;
		barWidth = percent * maxBarWidth;
		progressBarEmpty = new Texture2D(100, 10);
		progressBarFull = new Texture2D(100, 10);
	for (int i = 0; i<100; i++) {
		for (int j = 0; j<10; j++) {
			progressBarEmpty.SetPixel(i, j, Color.grey);

			progressBarFull.SetPixel(i, j, Color.blue);
		}
	};
		progressBarEmpty.Apply();
		progressBarFull.Apply();
		//renderer.material.mainTexture = progressBarFull;
   		GUI.DrawTexture(new Rect(pos.x, pos.y, size.x * Mathf.Clamp01(currValue), size.y), progressBarFull, ScaleMode.ScaleAndCrop, false, size.x/size.y);

	}
	
	// Update is called once per frame
	
	void Update () {
		/*Vector3 cameraMousePoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		transform.LookAt(cameraMousePoint - Camera.main.transform.position, Vector3.back);*/
		if (currValue < 0) {
			currValue = 0;
		}
		percent = ((float)currValue)/maxValue;
		barWidth = Screen.width / 4;

		//left = (int) Screen.width / 2;	
		
	}
	
	void increaseValue(int i) {
		currValue += i;
	}
	
	void OnGUI() {
		GUI.DrawTexture(new Rect(pos.x, pos.y, size.x, size.y), progressBarEmpty);
		GUI.BeginGroup(new Rect (pos.x, pos.y, size.x * Mathf.Clamp01(percent), size.y));
		GUI.DrawTexture(new Rect(0, 0, size.x, size.y), progressBarFull);
		GUI.EndGroup();
	}
}

