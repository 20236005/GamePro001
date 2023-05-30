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
        //Time_gauge�̏����擾����
        this.Timegaugi = GameObject.Find("Time_gauge");
        //Distance�̏����擾����
        this.Distance = GameObject.Find("Distance");
    }
    public void DecreaseTime()
    {
        //�G�ƏՓ˂�����Timegauge�����炷
        this.Timegaugi.GetComponent<Image>().fillAmount -= 0.25f;
    }

    public void DecreaseTime2()
    {
        //Myshot�ƓG���Փ˂�����Timegauge�𑝂₷
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
