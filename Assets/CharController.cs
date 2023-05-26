using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.IMGUI.Controls.PrimitiveBoundsHandle;

public class CharController : MonoBehaviour
{
    public GameObject Myshot;
    public GameObject Enemy;
    GameObject cher;
    float span = 1.0f;
    float delta = 0;

    Animator animator;

    void Start()
    {
        this.animator = GetComponent<Animator>();
        this.cher = GameObject.Find("MyChar");
    }

    void Update()
    {
        //移動
        Vector3 dir = Vector3.zero;
        float speed = 0.250f;
        dir.x = Input.GetAxisRaw("Horizontal");
        dir.y = Input.GetAxisRaw("Vertical");
        transform.position += dir.normalized * speed;

        // プレイヤーの位置
        Vector3 PlayerPos = this.cher.transform.position;
        transform.position = new Vector3(PlayerPos.x, PlayerPos.y, 0);

        this.delta += Time.deltaTime;

        //クリックしたらGrassを投げる
        if (Input.GetMouseButtonDown(0))
        {
            if (this.delta > this.span)
            {
                this.delta = 0;
                GameObject go = Instantiate(Myshot);
                go.transform.position = new Vector3(PlayerPos.x, PlayerPos.y, 0);
            }
        }
    }

    //当たり判定
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            GameObject director = GameObject.Find("GameDirecter");
            director.GetComponent<GameDirecter>().DecreaseTime();
        }
    }
}
