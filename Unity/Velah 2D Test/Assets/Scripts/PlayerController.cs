using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public static PlayerController instance;

    public float speed = 5f;

    private Animator anim;
    private Rigidbody2D rb2d;
    private Vector2 mov;

    void Awake()
    {
        // If there's another instance of this object, delete this one
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }

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
            anim.SetBool("walking", true);
        } else
        {
            anim.SetBool("walking", false);
        }
	}

    // FixedUpdate is called once per frame (alongside physics)
    void FixedUpdate () {
        rb2d.MovePosition(rb2d.position + mov * speed * Time.deltaTime);
    }
}
