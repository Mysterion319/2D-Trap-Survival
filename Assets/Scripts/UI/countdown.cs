using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class countdown : MonoBehaviour
{
    float LevelTime = 0f;
    float BlubsStartingTime = 99;

    [SerializeField] Text BlubsCountDownText;
    // Use this for initialization
    void Start()
    {
        LevelTime = BlubsStartingTime;
    }

    // Update is called once per frame
    void Update()
    {
        LevelTime -= 1 * Time.deltaTime;
        BlubsCountDownText.text = LevelTime.ToString("0");




        if (LevelTime <= 0)
        {
            LevelTime = 0;
        }
          
    }

}

