using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDirecter : MonoBehaviour
{
    GameObject Score;
    int point = 0;
    public int highScore;

    void Start()
    {
        this.Score = GameObject.Find("Score");
        //�n�C�X�R�A�̒l��ۑ�
        highScore = PlayerPrefs.GetInt("SCORE", 0);
    }

    void Update()
    {
        this.Score.GetComponent<Text>().text = this.point.ToString();
    }

    public void DecreaseTime2()
    {
        this.point += 100;
    }

    public void DecreaseTime()
    {
        if (highScore < point)
        {
            highScore = point;
            PlayerPrefs.SetInt("SCORE", highScore);
            PlayerPrefs.Save();
        }
        this.Score.GetComponent<Text>().text = "����̃X�R�A" + this.point.ToString() + "�n�C�X�R�A" + this.highScore.ToString();
    }
}
