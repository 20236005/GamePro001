using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyGaugemuki : MonoBehaviour
{
    [SerializeField] Canvas canvas;

    void Start()
    {
        
    }

    void Update()
    {
        //EnemyGaugeをMain Cameraへ向かせる
        canvas.transform.rotation =
            Camera.main.transform.rotation;
    }
}
