using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class BlubsMenu : MonoBehaviour
{
    public Button PlayButton;
    public Button ControlButton;
    public Button ObjectiveButton;
    public Button QuitMenuButton;
    

 

    // Use this for initialization
    void Start()
    {
        PlayButton = PlayButton.GetComponent<Button>();
        ControlButton = ControlButton.GetComponent<Button>();
        ObjectiveButton = ObjectiveButton.GetComponent<Button>();
        QuitMenuButton = QuitMenuButton.GetComponent<Button>();
       
        
    }

   
    public void StartQuest()
    {
        SceneManager.LoadScene("Level1");
    }
    public void LoadQuestControls()
    {
        SceneManager.LoadScene("Controls");
    }
    public void LoadQuestGuide()
    {
        SceneManager.LoadScene("Objective");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}

