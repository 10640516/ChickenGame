using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VixAI : MonoBehaviour {

	public Rigidbody enemy;
	public float moveSpeed;
	public Transform target;
	public int damage;
	public GameObject pcHealth;


	void OnTriggerStay(Collider other)
	{
		if(other.gameObject.name == "Player"){
			Debug.Log("Player has entered vixen's trigger");
			transform.LookAt(target);
			transform.Translate(Vector3.forward*moveSpeed*Time.deltaTime);
			
		}
		else if(other.gameObject.name == "Chickfilee"){
            Debug.Log("Chickfilee has entered vixen's trigger");
			transform.LookAt(target);
			transform.Translate(Vector3.forward*moveSpeed*Time.deltaTime);
			
		}

	}
	void OnCollisionEnter(Collision other)
	{
		if(other.gameObject.name == "Player"){
        var hit = other.gameObject;
		var health = hit.GetComponent<PlayerHealth>();
		print("Vixen is atacking");

		if(pcHealth != null){
			// pcHealth.TakeDamage(damage)
        pcHealth.gameObject.GetComponent<PlayerHealth>().TakeDamage(damage);
		}
	}
	}
}