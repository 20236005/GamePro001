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
        //Time_gaugeの情報を取得する
        this.Timegaugi = GameObject.Find("Time_gauge");

    }
    public void DecreaseTime()
    {
        //敵と衝突したらTimegaugeを減らす
        this.Timegaugi.GetComponent<Image>().fillAmount -= 0.25f;
    }
    public void DecreaseTime2()
    {
        //Playerと衝突したらTimegaugeを増やす
        this.Timegaugi.GetComponent<Image>().fillAmount += 0.25f;
    }
    public void DecreaseTime3()
    {
        //敵と衝突したらTimegaugeを減らす
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
