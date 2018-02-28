using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicPlayer : MonoBehaviour {

	void Awake () {
        Invoke("LoadFirstScene", 3);
        DontDestroyOnLoad(gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void LoadFirstScene()
    {
        SceneManager.LoadScene(1);
    }
}
