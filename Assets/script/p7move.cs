using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class p7move : MonoBehaviour
{
    Rigidbody2D rb;
    float horizontal;
    float vertical;

    public float speed;

    private Text scoreText;
    
    // Start is called before the first frame update
    void Start()
    {
        score.nilai = 0;
        scoreText = GameObject.Find("ScoreText").GetComponent<Text>();
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * speed, vertical * speed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("point"))
        {
            Destroy(collision.gameObject);
            score.AddScore(1);
            scoreText.text = "Score : " + score.nilai;


            
        }
    }

    
}
