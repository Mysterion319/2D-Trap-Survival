using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class GraveyardLetter : MonoBehaviour
{
    public Button Enterlevel2Button;
   



    // Use this for initialization
    void Start()
    {
        Enterlevel2Button = Enterlevel2Button.GetComponent<Button>();
       

    }



    public void LoadGraveyard()
    {
        SceneManager.LoadScene("Level2");
    }
    

}