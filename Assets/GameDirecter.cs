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
    public void DecreaseTime2()
    {
        //Player�ƏՓ˂�����Timegauge�𑝂₷
        this.Timegaugi.GetComponent<Image>().fillAmount += 0.25f;
    }
    public void DecreaseTime3()
    {
        //�G�ƏՓ˂�����Timegauge�����炷
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
