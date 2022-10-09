using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
//Hello, Nice to meet you. I majored in computer science
{
    public string type;
    Rigidbody2D riged;

    void Awake()
    {
        riged = GetComponent<Rigidbody2D>();
        riged.velocity = Vector2.down * 3;

    }
}
