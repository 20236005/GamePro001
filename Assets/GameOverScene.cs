using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScene : MonoBehaviour
{
    void Update()
    {
        //�Q�[���p�b�g�̂O�{�^���������ꂽ��
        if (Input.GetButtonDown("Fire1"))
        {
            SceneManager.LoadScene("GameScene");
        }
    }
}
