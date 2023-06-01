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
    
    void Update()
    {
        if (this.Timegaugi.GetComponent<Image>().fillAmount == 0 )
        {
            GameObject ScoreDirecter = GameObject.Find("ScoreDirecter");
            ScoreDirecter.GetComponent<ScoreDirecter>().DecreaseTime();
        }   
    }
}
