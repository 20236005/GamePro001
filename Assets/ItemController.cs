using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour
{
    float Speed = -0.10f;

    void Update()
    {
        transform.Translate(this.Speed, 0, 0);


        //êŠO‚Éo‚½‚ç‰ó‚ê‚é

        if (transform.position.x < -32.0f)
        {
            Destroy(gameObject);
        }     
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            GameObject Item = GameObject.Find("GameDirecter");
            Item.GetComponent<GameDirecter>().DecreaseTime2();
            Destroy(gameObject);
        }
    }
}
