using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMove : MonoBehaviour
{
    Rigidbody2D rb;

    private float speed = 0.2f;
    Vector3 mouseposition;
    Vector2 posisi = new Vector2 (0f,0f);

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        mouseposition = Input.mousePosition;
        mouseposition = Camera.main.ScreenToWorldPoint(mouseposition);
        posisi = Vector2.Lerp(transform.position, mouseposition, speed);
    }

    private void FixedUpdate()
    {
        rb.MovePosition(posisi);
    }
}
