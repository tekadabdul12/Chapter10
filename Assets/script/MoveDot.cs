using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDot : MonoBehaviour
{
    Rigidbody2D rb;

    public float kecepatan ;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Gerak();
    }

    void Gerak()
    {
        rb.velocity = new Vector2(kecepatan, kecepatan);
    }
}
