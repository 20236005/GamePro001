using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyShotController : MonoBehaviour
{
    public GameObject Enemy;
    float speed = 0.50f;

    void Start()
    {
        Application.targetFrameRate = 60;
    }

    void Update()
    {
        //�ړ�
        transform.Translate(0, this.speed, 0);

        //��O�ɏo�������
        if (transform.position.x > 33.0f)
        {
            Destroy(gameObject);
        }
        if (transform.position.x < -33.0f)
        {
            Destroy(gameObject);
        }
    }
    //�����蔻��
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
        }
    }
}
