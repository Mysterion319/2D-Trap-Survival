using UnityEngine;
using System.Collections;
/**
* Looking at the player movement class allows the character, to move set the speed
* then also I can set how high the character jumps and how far the ground is beneath him.
*/
//Adding this allows us to access members of the UI namespace including Text.
using UnityEngine.UI;

public class Playermovement : MonoBehaviour
{

    public float speed; //Floating point variable to store the player's movement speed.
    private float CharacterMoveInput;// A float which is used so I can adjust which way the character will be moving.
    public float BlubJumpForce;// Used for how forceful I want jump to be able to jump.
    private float BlubJumpTimeCounter;
    public float BlubJumpTime;
    private bool BlubIsJumping;
    private bool isGrounded;//Needed so when the character is grounded, he can jump.
    public AudioSource jump;//Allows an audio source to be able to be added to input my jump sound.
    public LayerMask WhatIsGround;// For when a layer needs to be added to ground to help with jumping.

    public AudioSource ChurchChime;//Allows the church sound to be added by the audio source.
    private Rigidbody2D rb2d;       //Store a reference to the Rigidbody2D component required to use 2D Physics.
    public Transform BlubFeetPos;//A game object to check if blub is near enough to the ground to jump.

    public float CheckFloorRadius;//Needed so the game object can check the radius of the floor.

    void Start()
    {

        rb2d = GetComponent<Rigidbody2D>();

    }

    //FixedUpdate is called at a fixed interval and is independent of frame rate. Put physics code here.
    void FixedUpdate()
    {
        CharacterMoveInput = Input.GetAxisRaw("Horizontal");//Have the main character move horizontal down the axies i.e left and right.
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

        if (isGrounded == true && Input.GetKeyDown(KeyCode.Space))//If blub is somewhere that is ground then he can jump.
        {
            BlubIsJumping = true;
            BlubJumpTimeCounter = BlubJumpTime;
            rb2d.velocity = Vector2.up * BlubJumpForce;//So the jump force allows blub to be able to go up when he jumps.
            jump.Play();//To have the sound play when the character jumps.

        }





    }
    void OnTriggerEnter2D(Collider2D other)
    {


    }



}


