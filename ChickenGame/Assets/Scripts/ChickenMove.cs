using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenMove : MonoBehaviour {

	public Rigidbody enemy;
	public float moveSpeed;

	public float jumpHeight;
	public Transform target;

	public Transform chickenPen;


	void OnTriggerStay(Collider other)
	{
		if(other.gameObject.name == "Player"){
			Debug.Log("Player has entered chickens trigger");
			transform.LookAt(target);
			transform.Translate(Vector3.forward*-moveSpeed*jumpHeight*Time.deltaTime);
			
		}

	}
	void OnCollisionEnter(Collision other)
	{
		if(other.gameObject.name == "Player"){
			transform.position = chickenPen.position;
			transform.rotation = chickenPen.rotation;
		}
		
	}
}
