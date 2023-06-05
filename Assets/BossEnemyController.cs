using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossEnemyController : MonoBehaviour
{
    int damezi = 0;
    float Speedx = 0f;
    float Speedy = 0f;
    float time = 0f;

    float xLimit = 25.0f;
    float yLimit = 10.0f;

    GameObject Boss;
    public GameObject MyShot;

    void Start()
    {
        this.Boss = GameObject.Find("Boss Enemy ");

    }

    void Update()
    {
        //ボスの位置
        Vector3 BossPos = this.Boss.transform.position;
        transform.position = new Vector3(BossPos.x, BossPos.y, 0);

        //移動制限
        Vector3 creentPos = transform.position;
        creentPos.x = Mathf.Clamp(creentPos.x, -xLimit, xLimit);
        creentPos.y = Mathf.Clamp(creentPos.y, -yLimit, yLimit);
        transform.position = creentPos;

        //速度
        transform.Translate(this.Speedx, this.Speedy, 0);

        this.time += Time.deltaTime;
        if (this.time == 3.0f)
        {
            this.time = 0f;
            Speedx = Random.Range(-0.3f, 0.5f);
            Speedy = Random.Range(-0.1f, 0.1f);
        }
    }
    //当たり判定
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "MyShot")
        {
            ++damezi;

            if (damezi == 100)
                {
                    Destroy(gameObject);
                SceneManager.LoadScene("ClearScene");
            }
        }
    }
}
