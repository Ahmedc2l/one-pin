using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {
	public static int PinCount;
	public Text scoreText;
	public Text highScoreText;

	void Start ()
	{
		PinCount = 0;
	}

	void Update ()
	{
		scoreText.text = PinCount.ToString();
		highScoreText.text = string.Format("Highest Score : {0}",PlayerPrefs.GetInt ("HighScore", 0));
	}
}