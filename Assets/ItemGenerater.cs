using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerater : MonoBehaviour
{
    public GameObject Item;
    float span = 5f;
    float delta = 0;

    void Update()
    {
        //ƒ‰ƒ“ƒ_ƒ€‚ÉŒ»‚ê‚é
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(Item);
            int x = Random.Range(33, 36);
            int y = Random.Range(-13, 16);
            go.transform.position = new Vector3(x, y, 0);
        }
    }
}
