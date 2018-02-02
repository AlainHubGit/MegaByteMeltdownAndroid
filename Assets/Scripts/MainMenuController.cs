using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour {

    SceneManager scene = new SceneManager();

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void StartGame()
    {
        //Application.LoadLevel("test");
        SceneManager.LoadScene("level_1");
    }

    public void EndGame()
    {
        Application.Quit();
    }

    




}
