/*
using UnityEngine;
using System.Collections;

public class Gui {
	public int currValue;
	public int maxValue;
	public static Vector2 pos;
	public Vector2 size;
	public Texture2D progressBarEmpty;// = new Texture2D(100, 30);
	public Texture2D progressBarFull;// = new Texture2D(100, 30);

	public float percent;
	public float barWidth;
	public int maxBarWidth;
	public int left;
	public int top;
	
	public Gui(Vector2 pos, Vector2 size,
		Texture2D progressBarEmpty, Texture2D progressBarFull,
		int maxBarWidth, int maxValue, int currValue,
		int left, int top) {
		
		this.pos = pos;
		this.size = size;
		this.progressBarEmpty = progressBarEmpty;
		this.progressBarFull = progressBarFull;
		this.maxBarWidth = maxBarWidth;
		this.currValue = currValue;
		this.maxValue = maxValue;
		this.percent = ((float) currValue)/maxValue;
		this.left = left;
		this.top = top;
	}
	
	public static void Start() {
   		GUI.DrawTexture(new Rect(pos.x, pos.y, size.x * Mathf.Clamp01(currValue), size.y), progressBarFull, ScaleMode.ScaleAndCrop, false, size.x/size.y);
	}
	
	public static void Update () {
		percent = ((float)currValue)/maxValue;
	}
	public static void increaseValue(int i) {
		this.currValue += i;
		if (this.currValue < 0) {
			this.currValue = 0;
		}
	}
	public static void OnGUI() {
		GUI.DrawTexture(new Rect(pos.x, pos.y, size.x, size.y), progressBarEmpty);
		GUI.BeginGroup(new Rect (pos.x, pos.y, size.x * Mathf.Clamp01(percent), size.y));
		GUI.DrawTexture(new Rect(0, 0, size.x, size.y), progressBarFull);
		GUI.EndGroup();	
	}
}*/