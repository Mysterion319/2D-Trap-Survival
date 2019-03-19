using UnityEngine;
using System.Collections;

//Adding this allows us to access members of the UI namespace including Text.
using UnityEngine.UI;

public class LetterPickUp : MonoBehaviour
{

    public AudioSource ChurchChime;
    public Text LetterCollected;         

    private Rigidbody2D rb2d;      
    private int count;              

    // Use this for initialization
    void Start()
    {


        count = 0;

       


       
        SetLetterCollected();
    }

   
    void FixedUpdate()
    {



    }

   
    void OnTriggerEnter2D(Collider2D other)
    {
       
        if (other.gameObject.CompareTag("Love_Letter"))
            ChurchChime.Play();

        other.gameObject.SetActive(false);

      
        count = count + 1;

      
        SetLetterCollected();
     
    }

    
    void SetLetterCollected()
    {
        
        LetterCollected.text = "Letter Collected " + count.ToString();


    }
}


