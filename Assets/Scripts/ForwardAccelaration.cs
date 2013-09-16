using UnityEngine;
using System.Collections;

public class ForwardAccelaration : MonoBehaviour {
	
	public float accelaration = 10.0f;
	public float smooth = 10.0f;
	public Light engine;
	public float maxGlow = 10.0f;
	
	void Update () {
		Vector3 v = transform.forward;
		v.z = 0.0f;
		Vector3 force = new Vector3(0.0f,0.0f,0.0f);
		float glow = 0.0f;
		if (Input.GetMouseButton(1)) {
			force = v * accelaration;		
			glow = maxGlow;
		}
		rigidbody.AddForce(force);
		engine.intensity = Mathf.Lerp(engine.intensity, glow, Time.deltaTime * smooth);
	}
}
