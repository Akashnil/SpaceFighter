using UnityEngine;
using System.Collections;

public class PointingBehavior : MonoBehaviour {
	
	void Update () {
		Vector3 cameraMousePoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		transform.LookAt(cameraMousePoint - Camera.main.transform.position, Vector3.back);
	}
}
