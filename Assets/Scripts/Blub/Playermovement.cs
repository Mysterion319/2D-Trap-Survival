using UnityEngine;
using System.Collections;

//Adding this allows us to access members of the UI namespace including Text.
using UnityEngine.UI;

public class Playermovement : MonoBehaviour
{

    public float speed;             //Floating point variable to store the player's movement speed.
    private float CharacterMoveInput;
    public float BlubJumpForce;

    public AudioSource jump;


    private Rigidbody2D rb2d;       //Store a reference to the Rigidbody2D component required to use 2D Physics.
    private bool isGrounded;
    public Transform BlubFeetPos;
    public float CheckFloorRadius;
    public LayerMask WhatIsGround;

    private float BlubJumpTimeCounter;
    public float BlubJumpTime;
    private bool BlubIsJumping;


    // Use this for initialization
    void Start()
    {
        //Get and store a reference to the Rigidbody2D component so that we can access it.
        rb2d = GetComponent<Rigidbody2D>();


    }

    //FixedUpdate is called at a fixed interval and is independent of frame rate. Put physics code here.
    void FixedUpdate()
    {
        CharacterMoveInput = Input.GetAxisRaw("Horizontal");
        rb2d.velocity = new Vector2(CharacterMoveInput * speed, rb2d.velocity.y);
    }


    void Update()
    {

        isGrounded = Physics2D.OverlapCircle(BlubFeetPos.position, CheckFloorRadius, WhatIsGround);


        if (CharacterMoveInput > 0)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
        else if (CharacterMoveInput < 0)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);

        }

        if (isGrounded == true && Input.GetKeyDown(KeyCode.Space))
        {
            BlubIsJumping = true;
            BlubJumpTimeCounter = BlubJumpTime;
            rb2d.velocity = Vector2.up * BlubJumpForce;
            jump.Play();

        }

        }

    }

