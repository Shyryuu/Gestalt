using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combat_Attack_Button : MonoBehaviour {

    public GameObject player;
    public GameObject enemy;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void Attack(GameObject x, GameObject y)
    {
        Debug.Log("<b>Your button works!</b>");
    }
}
