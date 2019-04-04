using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class HowToPlay : MonoBehaviour
{
    public Button ControlsButton;




    // Use this for initialization
    void Start()
    {
        ControlsButton = ControlsButton.GetComponent<Button>();


    }



    public void ReturnToMenu()
    {
        SceneManager.LoadScene("StartMenu");
    }


}