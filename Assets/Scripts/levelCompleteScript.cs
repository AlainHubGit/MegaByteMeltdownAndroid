using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelCompleteScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
    void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.gameObject.tag == "Player")
        {
            print(this.gameObject.name);
			//SceneManager.LoadScene("level_2");
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

	// Update is called once per frame
	void Update () {
		
	}
}
