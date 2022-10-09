using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
//Hello, Nice to meet you. I majored in computer science
{
    public int dmg;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "BorderBullet")
        {
            Destroy(gameObject);
        }
    }
}
}
