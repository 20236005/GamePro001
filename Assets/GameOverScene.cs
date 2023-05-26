using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScene : MonoBehaviour
{
    void Update()
    {
        //ゲームパットの０ボタンが押されたら
        if (Input.GetButtonDown("Fire1"))
        {
            SceneManager.LoadScene("GameScene");
        }
    }
}
