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
        //Time_gauge�̏����擾����
        this.Timegaugi = GameObject.Find("Time_gauge");

    }
    public void DecreaseTime()
    {
        //�G�ƏՓ˂�����Timegauge�����炷
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
