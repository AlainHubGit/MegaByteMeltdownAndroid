using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {
	// An array to hold multiple hazards
	public GameObject [] hazards;
	public Vector2 spawnValues;
	public Vector2 spawnValues2;
	public Quaternion spawnRotation;
	public int hazardCount;
	public float spawnWait;
	public float startWait;
	public float waitNewWave;
	//For displaying Text
	public Text scoreText;
	// public Text restartText;
	// public Text gameOverText;

	// Will help us track when the game is over and when to restart
	// private bool gameOver;
	// private bool restart;

	// To save the score
	 private int score;


	void Start()
	{
		//gameOver = false;
		// restart = false;
		// Set starting text in new labels
		//restartText.text = "";
		//gameOverText.text = "";
		 score = 0;
		UpdateScore ();
		//StartCoroutine(SpawnWaves());
	}

	void Update()
	{/*
		if (restart) 
		{
			if(Input.GetKeyDown (KeyCode.R))
				{
					UnityEngine.SceneManagement.SceneManager.LoadScene(0);
				}
		}
		*/
	}

	void OnTriggerEnter2D(Collider2D coll)
	{
		if(coll.gameObject.tag == "Player")
		{
			 StartCoroutine("SpawnWaves");
			//Debug.Log ("Player pressed button");

		}
	}

	IEnumerator SpawnWaves()
	{
		yield return new WaitForSeconds(startWait);
		while(true)
		{
			for(int i = 0; i < hazardCount; i++)
			{
				GameObject hazard = hazards[Random.Range(0, hazards.Length)];
				Vector2 spawnPosition = new Vector2 (Random.Range(spawnValues.x, spawnValues2.x), spawnValues.y);
				Quaternion spawnRotation = Quaternion.identity;
				 Instantiate (hazard, spawnPosition, spawnRotation);
				yield return new WaitForSeconds(spawnWait);
			}
			yield return new WaitForSeconds (waitNewWave);
		}
	}

	public void AddScore(int newScoreValue)
	{
		score += newScoreValue;
		UpdateScore ();
	}

	void UpdateScore()
	{
        
		scoreText.text = "Files Infected: " + score;
		Debug.Log("Files Infected: " + score);
	}
	/*
	public void GameOver()
	{
		gameOverText.text = "Game Over!";	
		// Set gameOver flag to true.
		gameOver = true;
	}
*/
}
