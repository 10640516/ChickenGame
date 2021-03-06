﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour {
	public static int score;

	public int scoreAmount = score;
	public int winScore;
	public Text text;

	public Text winText;

	void Awake()
	{
		Time.timeScale = 1;
	}
	void Start () {
		winText.GetComponent<Text>().enabled = false;
		text = GetComponent<Text>();
		score = 0;
	}
	
	void Update () {
		if(score < 0)
			score = 0;
	    text.text = "  " + score;
		
		// If the player win display win text
		if(winScore == score){
			print("Win Score Reached" + score);
			winText.GetComponent<Text>().enabled = true;
			Time.timeScale = 0;
		}
		if(Input.GetKeyDown(KeyCode.Escape)){
			SceneManager.LoadScene(0);
		}
	}

	public static void AddPoints(int pointstoAdd){
		score += pointstoAdd;
	}
	public void Reset()
	{
		score=0;
	}
}