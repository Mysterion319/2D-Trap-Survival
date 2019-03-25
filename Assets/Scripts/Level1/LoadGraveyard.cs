using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class LoadGraveyard : MonoBehaviour
{
    public Button EntergraveyardButton;//Defines the button that i created.




    // Use this for initialization
    void Start()
    {
        EntergraveyardButton = EntergraveyardButton.GetComponent<Button>();// i define the button again as this allows me to be able to press the button.


    }



    public void EnterSecondLevel()
    {
        SceneManager.LoadScene("Level2");//Once the button has been pressed it will load the scenemanager allowing the second level to load.
    }


}