using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
/**
* In this script it will allow me to be able to add the countdown text to the
* canvas just like the letter pick script. then i am able to set the level time
* which is how long the player has left to complete the level. Also i am able to
* set when the level time hits 0 then the scene is going to change to game over screen.
*/
public class LevelCountDown : MonoBehaviour
{
    float LevelTime = 0f;//The end time before the game over.
    float BlubsStartingTime = 60;//The start of the timer for the player.

    [SerializeField] Text BlubsCountDownText;//The text needed to apply the countdown script to the canvas.
    // Use this for initialization
    void Start()
    {
        LevelTime = BlubsStartingTime;//Defining the level starting time.
    }

    void Update()
    {
        LevelTime -= 1 * Time.deltaTime;//For the timer to count down by one second.
        BlubsCountDownText.text = LevelTime.ToString("Time Left = 0");//String to show the player how much time is left.




        if (LevelTime <= 0)
        {
            LevelTime = 0;// So the timer can not go past 0.
            SceneManager.LoadScene("GameOver");//loads the game over scene.
        }

    }

}

