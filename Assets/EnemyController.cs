using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    float Speed = -0.10f;
    public GameObject MyShot;
    Animator animator;

    void Start()
    {
        this.animator = GetComponent<Animator>();
    }
    void Update()
    {
        transform.Translate(this.Speed, 0, 0);


        //場外に出たら壊れる
       
        if (transform.position.x < -32.0f)
        {
            Destroy(gameObject);
        }

    }
    //当たり判定
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "MyShot")
        {
            Destroy(gameObject);
        }
        if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
