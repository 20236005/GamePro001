using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameDirecter : MonoBehaviour
{
    GameObject Timegaugi;
    GameObject Distance;
    float distance = 0;

    void Start()
    {
        //Time_gaugeの情報を取得する
        this.Timegaugi = GameObject.Find("Time_gauge");
        //Distanceの情報を取得する
        this.Distance = GameObject.Find("Distance"); 
    }
    public void DecreaseTime()
    {
        //敵と衝突したらTimegaugeを減らす
        this.Timegaugi.GetComponent<Image>().fillAmount -= 0.25f;
    }

    public void DecreaseTime2()
    {
        //Myshotと敵が衝突したらTimegaugeを増やす
        this.Timegaugi.GetComponent<Image>().fillAmount += 0.025f;
    }


    void Update()
    {
        this.distance += Time.deltaTime * 10;
        this.Distance.GetComponent<TextMeshProUGUI>().text = this.distance.ToString("F1");

        this.Timegaugi.GetComponent<Image>().fillAmount -= 0.0005f;

        //if(this.Timegaugi )
        //{
        //    SceneManager.LoadScene("GameOverScene");
        //}
    }


}
