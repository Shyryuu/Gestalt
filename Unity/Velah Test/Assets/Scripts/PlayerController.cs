using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    // Movement keys (set in the editor)
    public KeyCode up;
    public KeyCode down;
    public KeyCode left;
    public KeyCode right;

    // Player movement speed
    public float speed = 10f;
    // Here we get (from the editor) a random tile (all are equal). This will be needed to get the tile size.
    public GameObject tile;
    public float tileSize;

    // Movement helping variables
    private bool moving = false;
    // 1=up, 2=down, 3=left, 4=right
    private short direction;
    private float targetPos;
    // Makes easier to know if the player reached the targetPos. Bigger = Less precision
    // If the movement works OK leave it to 0. If not, try 0.1f or 0.2f, something like this.
    private float targetPosOffset = 0f;

	// Use this for initialization
	void Start () {
        // Here we get the tile size, which is the distance the player has to move
        tileSize = tile.transform.lossyScale.z;
    }
	
	// Update is called once per frame
	void Update () {
        /**
        // Standard movement mode
		if (Input.GetKey(up))
        {
            transform.Translate(0, 0, speed * Time.deltaTime);
        }
        if (Input.GetKey(down))
        {
            transform.Translate(0, 0, -speed * Time.deltaTime);
        }
        if (Input.GetKey(left))
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(right))
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }
        **/

        // Tiles movement mode
        if (!moving)
        {
            if (Input.GetKey(up))
            {
                moving = true;
                direction = 1;
                targetPos = transform.position.z + tileSize - targetPosOffset;
                transform.Translate(0, 0, speed * Time.deltaTime);
            }
            if (Input.GetKey(down))
            {
                moving = true;
                direction = 2;
                targetPos = transform.position.z - tileSize + targetPosOffset;
                transform.Translate(0, 0, -speed * Time.deltaTime);
            }
            if (Input.GetKey(left))
            {
                moving = true;
                direction = 3;
                targetPos = transform.position.x - tileSize - targetPosOffset;
                transform.Translate(-speed * Time.deltaTime, 0, 0);
            }
            if (Input.GetKey(right))
            {
                moving = true;
                direction = 4;
                targetPos = transform.position.x + tileSize + targetPosOffset;
                transform.Translate(speed * Time.deltaTime, 0, 0);
            }
        }
        else
        {
            if (direction == 1)
            {
                transform.Translate(0, 0, speed * Time.deltaTime);
                if (transform.position.z >= targetPos)
                {
                    moving = false;
                }
            }
            else if (direction == 2)
            {
                transform.Translate(0, 0, -speed * Time.deltaTime);
                if (transform.position.z <= targetPos)
                {
                    moving = false;
                }
            }
            else if (direction == 3)
            {
                transform.Translate(-speed * Time.deltaTime, 0, 0);
                if (transform.position.x <= targetPos)
                {
                    moving = false;
                }
            }
            else if (direction == 4)
            {
                transform.Translate(speed * Time.deltaTime, 0, 0);
                if (transform.position.x >= targetPos)
                {
                    moving = false;
                }
            }
        }
        
    }
}
