using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    public static AudioClip Jumpsound, Deathsound;
    static AudioSource audiosource;

    // Use this for initialization
    void Start()
    {

        Jumpsound = Resources.Load<AudioClip>("Jump");
        Deathsound = Resources.Load<AudioClip>("Death");

        audiosource = GetComponent<AudioSource>();



    }

    // Update is called once per frame
    void Update()
    {

    }

    public static void RunSound(string play)
    {
        switch (play)
        {
            case "jump":
                audiosource.PlayOneShot(Jumpsound);
                break;
            case "Death":
                audiosource.PlayOneShot(Deathsound);
                break;

        }



    }

}






