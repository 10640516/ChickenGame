using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VixHealth : MonoBehaviour {
	public int currentHealth;
	public int maxHealth = 3;
	public Transform shootPoint;
	public int points;

	// Use this for initialization
	void Start()
	{
		currentHealth = maxHealth;
	}
	public void TakeDamage(int amount) {
		currentHealth -= amount;
		if(currentHealth <= 0){
			currentHealth=0;
			print("Vixen is Dead!");

			ScoreManager.AddPoints(points);
			transform.position = shootPoint.position;
			transform.rotation = shootPoint.rotation;
			currentHealth = maxHealth;
		}
	}
}
