using UnityEngine;
using System.Collections;

//Adding this allows us to access members of the UI namespace including Text.
using UnityEngine.UI;

public class Playermovement : MonoBehaviour
{

 public float speed; //Floating point variable to store the player's movement speed.
 private float CharacterMoveInput;// A float which is used so i can adjust which way the character will be moving.
 public float BlubJumpForce;// Used for how forcful i want jump to be able to jump.
 private float BlubJumpTimeCounter;
 public float BlubJumpTime;
 private bool BlubIsJumping;
 private bool isGrounded;//Needed so when the character is grounded he can jump.
 public AudioSource jump;//Allows an audio source to be able to be added to input my jump sound.
 public LayerMask WhatIsGround;// For when a layer needs to be added to ground to help with jumping.


 public AudioSource ChurchChime;//Allows the church sound to be added by the audio source.
 private Rigidbody2D rb2d;       //Store a reference to the Rigidbody2D component required to use 2D Physics.
 public Transform BlubFeetPos;//A gameobject to check if blub is near enough to the ground to jump.
 public Text LetterCollected;//Needed so the canvas can be connected to the player and have the letter collected update.
 private int count;//Needed for letter count.
 public float CheckFloorRadius;//Needed so the gameobject can check the radius of the floor.
 
    void Start()
    {
       
        rb2d = GetComponent<Rigidbody2D>();
        count = 0;//Starts the count from zero so the player knows the letter has not been collected.
        SetLetterCollected();

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

        if (other.gameObject.CompareTag("Love_Letter"))//The object that has the tag love letter are able to be picked up by blub.
            ChurchChime.Play();

        other.gameObject.SetActive(false);


        count = count + 1;//Add one to the Letter collected UI when the letter has been picked up.


        SetLetterCollected();

    }

    void SetLetterCollected()
    {

        LetterCollected.text = "Letter Collected " + count.ToString();//Allows the text from the canvas to be able to be added to blub so when letter is picked up the canvas text updates.


    }

}

