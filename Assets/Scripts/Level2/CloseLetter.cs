using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
/**
* Then pressing the load castle button script will will load allowing
* me to be able to load the final level.
*/
public class CloseLetter : MonoBehaviour
{
    public Button BackToLevel;//Adds the boss battle button to the letter.




    // Use this for initialization
    void Start()
    {
        BackToLevel = BackToLevel.GetComponent<Button>();//Allows the trigger for the boss battle button.


    }



    public void HeadBack()
    {
        SceneManager.LoadScene("Level2");//Loads the final scnene
    }


}