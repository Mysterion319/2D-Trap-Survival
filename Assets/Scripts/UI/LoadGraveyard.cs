using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class LoadGraveyard : MonoBehaviour
{
    public Button EntergraveyardButton;




    // Use this for initialization
    void Start()
    {
        EntergraveyardButton = EntergraveyardButton.GetComponent<Button>();


    }



    public void EnterSecondLevel()
    {
        SceneManager.LoadScene("Level2");
    }


}