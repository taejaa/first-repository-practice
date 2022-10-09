using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public string type;
    Rigidbody2D riged;

    void Awake()
    {
        riged = GetComponent<Rigidbody2D>();
        riged.velocity = Vector2.down * 3;

    }
}
