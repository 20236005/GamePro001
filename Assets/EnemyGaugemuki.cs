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
        //EnemyGauge��Main Camera�֌�������
        canvas.transform.rotation =
            Camera.main.transform.rotation;
    }
}
