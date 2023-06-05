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
    public void DecreaseTime2()
    {
        //Player‚ÆÕ“Ë‚µ‚½‚çTimegauge‚ğ‘‚â‚·
        this.Timegaugi.GetComponent<Image>().fillAmount += 0.25f;
    }
    public void DecreaseTime3()
    {
        //“G‚ÆÕ“Ë‚µ‚½‚çTimegauge‚ğŒ¸‚ç‚·
        this.Timegaugi.GetComponent<Image>().fillAmount -= 0.5f;
    }

    void Update()
    {
        if (this.Timegaugi.GetComponent<Image>().fillAmount == 0 )
        {
            SceneManager.LoadScene("GameOverScene");
        }   
    }
}
