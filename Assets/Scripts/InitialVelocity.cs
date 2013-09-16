using UnityEngine;
using System.Collections;

public class InitialVelocity : MonoBehaviour {

	public float initialVelocity = 10000.0f;
	
	void Start () {
		rigidbody.AddForce(initialVelocity * transform.forward);
	}
}
