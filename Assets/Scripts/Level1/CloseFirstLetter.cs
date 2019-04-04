using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
/**
* Then pressing the load castle button script will load allowing
* me to be able to load the final level.
*/
public class CloseFirstLetter : MonoBehaviour
{
    public Button ClosefirstLetter;//Adds the boss battle button to the letter.




    // Use this for initialization
    void Start()
    {
        ClosefirstLetter = ClosefirstLetter.GetComponent<Button>();//Allows the trigger for the boss battle button.


    }



    public void GoBack()
    {
        SceneManager.LoadScene("Level1");//Loads the final scene
    }


}
