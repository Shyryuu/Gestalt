using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Combat_Escape_Button : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Escape()
    {
        Debug.Log("Escape button is working!");
        SceneManager.LoadScene("Game");
        SceneManager.SetActiveScene(SceneManager.GetSceneByName("Game"));
    }
}
