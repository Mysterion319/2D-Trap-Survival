using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class ObjectiveMenu : MonoBehaviour
{
    public Button ObjectiveMenuButton;
 



    // Use this for initialization
    void Start()
    {
        ObjectiveMenuButton = ObjectiveMenuButton.GetComponent<Button>();
        

    }



    public void ReturnToMenu()
    {
        SceneManager.LoadScene("StartMenu");
    }

}