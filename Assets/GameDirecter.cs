using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using System;

public class GameDirecter : MonoBehaviour
{
    GameObject Timegaugi;
   
    void Start()
    {
        //Time_gauge‚Ìî•ñ‚ğæ“¾‚·‚é
        this.Timegaugi = GameObject.Find("Time_gauge");

    }
    public void DecreaseTime()
    {
        //“G‚ÆÕ“Ë‚µ‚½‚çTimegauge‚ğŒ¸‚ç‚·
        this.Timegaugi.GetComponent<Image>().fillAmount -= 0.25f;
    }
    
    void Update()
    {
        if (this.Timegaugi.GetComponent<Image>().fillAmount == 0 )
        {
            GameObject ScoreDirecter = GameObject.Find("ScoreDirecter");
            ScoreDirecter.GetComponent<ScoreDirecter>().DecreaseTime();
        }   
    }
}
