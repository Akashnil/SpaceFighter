using UnityEngine;
using System.Collections;

public class LaserShooter : MonoBehaviour {
	
	public float coolDown = 0.3f;
	public Rigidbody laser;
	public GameObject firePoint;
	public float laserSpeed = 100.0f;
	int buffer = 0;
	
	
	void FixedUpdate () {
		buffer++;
		if (!Input.GetMouseButton(0)) {
			if (buffer * Time.deltaTime > coolDown)
				buffer--;
			return;
		}
		if (buffer * Time.deltaTime > coolDown) {
			buffer = 0;
			shoot();
		}
	}
	
	void shoot() {
		Rigidbody laserInstance;
		laserInstance = Instantiate(laser, firePoint.transform.position, firePoint.transform.rotation) as Rigidbody;
		laserInstance.AddForce(firePoint.transform.forward * laserSpeed);
	}
	
}
