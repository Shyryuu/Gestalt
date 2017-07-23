using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class warp : MonoBehaviour
{

    public GameObject target;
    private Vector3 targetPos;

    // Use this for initialization
    void Start()
    {
        // If target is Null throw an error
        Assert.IsNotNull(target);

        // Hide the sprite
        GetComponent<SpriteRenderer>().enabled = false;
        transform.GetChild(0).GetComponent<SpriteRenderer>().enabled = false;

        // Get the target position
        targetPos = target.transform.GetChild(0).transform.position;

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        col.transform.position = targetPos;
    }
}