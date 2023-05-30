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
        //Time_gauge‚Ìî•ñ‚ğæ“¾‚·‚é
        this.Timegaugi = GameObject.Find("Time_gauge");
        //Distance‚Ìî•ñ‚ğæ“¾‚·‚é
        this.Distance = GameObject.Find("Distance");
    }
    public void DecreaseTime()
    {
        //“G‚ÆÕ“Ë‚µ‚½‚çTimegauge‚ğŒ¸‚ç‚·
        this.Timegaugi.GetComponent<Image>().fillAmount -= 0.25f;
    }

    public void DecreaseTime2()
    {
        //Myshot‚Æ“G‚ªÕ“Ë‚µ‚½‚çTimegauge‚ğ‘‚â‚·
        this.Timegaugi.GetComponent<Image>().fillAmount += 0.025f;
    }

    void Update()
    {
        this.distance += Time.deltaTime * 100;
        this.Distance.GetComponent<TextMeshProUGUI>().text = this.distance.ToString("F1");

        this.Timegaugi.GetComponent<Image>().fillAmount -= 0.00020f;

        if (this.Timegaugi.GetComponent<Image>().fillAmount == 0 )
        {
            SceneManager.LoadScene("GameOverScene");
        }
    }
}
