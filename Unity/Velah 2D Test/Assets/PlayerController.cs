using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed = 5f;

    private Animator anim;
    private Rigidbody2D rb2d;
    private Vector2 mov;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
            mov = new Vector2(
            Input.GetAxisRaw("Horizontal"),
            Input.GetAxisRaw("Vertical")
        );

        // Update the animation parameters (to update the sprite)
        if (mov != Vector2.zero)
        {
            anim.SetFloat("MovX", mov.x);
            anim.SetFloat("MovY", mov.y);
        }
	}

    // FixedUpdate is called once per frame (alongside physics)
    void FixedUpdate () {
        rb2d.MovePosition(rb2d.position + mov * speed * Time.deltaTime);
    }
}
