using UnityEngine;
using System.Collections;

//Adding this allows us to access members of the UI namespace including Text.
using UnityEngine.UI;

public class Blub : MonoBehaviour
{

    public float speed;             //Floating point variable to store the player's movement speed.
    public float characterMoveInput;
    public Text LetterCollected;          //Store a reference to the UI Text component which will display the number of pickups collected.

    private Rigidbody2D rb2d;       //Store a reference to the Rigidbody2D component required to use 2D Physics.
    private int count;              //Integer to store the number of pickups collected so far.

    // Use this for initialization
    void Start()
    {
       

        //Initialize count to zero.
        count = 0;

        //Initialze winText to a blank string since we haven't won yet at beginning.


        //Call our SetCountText function which will update the text with the current value for count.
        SetLetterCollected();
    }

    //FixedUpdate is called at a fixed interval and is independent of frame rate. Put physics code here.
    void FixedUpdate()
    {
        characterMoveInput = Input.GetAxis("Horizontal");
        rb2d.velocity = new Vector2(characterMoveInput * speed, rb2d.velocity.y);




    }

    //OnTriggerEnter2D is called whenever this object overlaps with a trigger collider.
    void OnTriggerEnter2D(Collider2D other)
    {
        //Check the provided Collider2D parameter other to see if it is tagged "PickUp", if it is...
        if (other.gameObject.CompareTag("Love_Letter"))

            //... then set the other object we just collided with to inactive.
            other.gameObject.SetActive(false);

        //Add one to the current value of our count variable.
        count = count + 1;

        //Update the currently displayed count by calling the SetCountText function.
        SetLetterCollected();
    }

    //This function updates the text displaying the number of objects we've collected and displays our victory message if we've collected all of them.
    void SetLetterCollected()
    {
        //Set the text property of our our countText object to "Count: " followed by the number stored in our count variable.
        LetterCollected.text = "Count: " + count.ToString();


    }
}