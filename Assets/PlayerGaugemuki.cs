using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerGaugemuki : MonoBehaviour
{
    [SerializeField] Canvas canvas;

    void Update()
    {
        //EnemyGauge��Main Camera�֌�������
        canvas.transform.rotation =
            Camera.main.transform.rotation;
    }
}