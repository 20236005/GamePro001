using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using static UnityEditor.IMGUI.Controls.PrimitiveBoundsHandle;

public class CharController : MonoBehaviour
{
    public GameObject Myshot;
    public GameObject Enemy;
    GameObject cher;

    float span = 0.25f;
    float delta = 0;

    float threshold = 0.2f;

    float xLimit = 32.0f;
    float yLimit = 13.0f;

    Animator animator;

    void Start()
    {
        this.animator = GetComponent<Animator>();
        this.cher = GameObject.Find("MyChar");
    }

    void Update()
    {
        //�ړ�
        Vector3 dir = Vector3.zero;
        float speed = 0.10f;
        dir.x = Input.GetAxisRaw("Horizontal");
        dir.y = Input.GetAxisRaw("Vertical");
        transform.position += dir.normalized * speed;


        //�ړ�����
        Vector3 creentPos = transform.position;
        creentPos.x = Mathf.Clamp(creentPos.x, -xLimit, xLimit);
        creentPos.y = Mathf.Clamp(creentPos.y, -yLimit, yLimit);
        transform.position = creentPos;

        //�A�j���[�V����
        if (Input.acceleration.y > this.threshold)
        {
            this.animator.SetTrigger("Left Trigger");
        }

        if (Input.acceleration.y > - this.threshold)
        {
            this.animator.SetTrigger("Rigth Trigger");
        }

        // �v���C���[�̈ʒu
        Vector3 PlayerPos = this.cher.transform.position;
        transform.position = new Vector3(PlayerPos.x, PlayerPos.y, 0);

        this.delta += Time.deltaTime;

        //�N���b�N������Shot��ł�
        if (Input.GetMouseButtonDown(0))
        {
            if (this.delta > this.span)
            {
                this.delta = 0;
                GameObject go = Instantiate(Myshot);
                go.transform.position = new Vector3(PlayerPos.x, PlayerPos.y, 0);
            }
        }

            this.animator.speed = speed / 2.0f;
    }

    //�����蔻��
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            GameObject director = GameObject.Find("GameDirecter");
            director.GetComponent<GameDirecter>().DecreaseTime();
        }
    }
}
