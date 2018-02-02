using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pauseScript : MonoBehaviour {
    public bool paused;
    GameObject pauseMenu;
    AudioSource audio;
	// Use this for initialization
	void Start () {
        paused = false;
        audio = gameObject.GetComponent<AudioSource>();
        pauseMenu = gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject;
        pauseMenu.SetActive(false);
        audio.volume = 0.5f;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            paused = !paused;
        }
        if (paused)
        {
            Time.timeScale = 0f;
            pauseMenu.SetActive(true);
            audio.volume = 0.1f;
        } else if (!paused)
        {
            Time.timeScale = 1f;
            pauseMenu.SetActive(false);
            audio.volume = 0.5f;
        }
	}

    public void QuitGame()
    {
        print("Quitting");
        SceneManager.LoadScene("MainMenu");
    }
}
