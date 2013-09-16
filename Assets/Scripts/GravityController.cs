using UnityEngine;
using System.Collections;

public class GravityController : MonoBehaviour {
	
	public float GConstant = - 25000f;
	
	void FixedUpdate () {
		Vector3 v = transform.position;
		v.z = 0.0f;
		rigidbody.AddForce(GConstant * v / Mathf.Pow(v.magnitude, 3));
	}
}
