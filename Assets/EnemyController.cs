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


        //èÍäOÇ…èoÇΩÇÁâÛÇÍÇÈ
       
        if (transform.position.x < -32.0f)
        {
            Destroy(gameObject);
        }

    }
    //ìñÇΩÇËîªíË
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "MyShot")
        {
            GameObject Scren = GameObject.Find("ScoreDirecter");
            Scren.GetComponent<ScoreDirecter>().DecreaseTime2();
            Destroy(gameObject);
        }
        if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
