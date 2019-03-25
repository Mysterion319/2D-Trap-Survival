using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class LoadCastle : MonoBehaviour
{
    public Button LoadBossBattleButton;




    // Use this for initialization
    void Start()
    {
        LoadBossBattleButton = LoadBossBattleButton.GetComponent<Button>();


    }



    public void FinalBattle()
    {
        SceneManager.LoadScene("BossBattle");
    }


}