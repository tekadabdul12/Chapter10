using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveWithScore : MonoBehaviour
{
    Rigidbody2D rb;
    float horizontal;
    float vertical;

    public float speed;

    private Text scoreText;
    public GameObject point;

    
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

        arahgerak();
        
    }

    void arahgerak()
    {
        
        //flip
        Vector3 henshin = transform.localScale;
        if (horizontal < 0)
        {
            henshin.x = 0.2f;
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
        else if (horizontal > 0)
        {
            henshin.x = -0.2f;
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
        transform.localScale = henshin;

        //mutar
        if (vertical == -1)
        {
            
            if(henshin.x == -0.2f)
            {
                transform.localRotation = Quaternion.Euler(0, 0, -90);
            }
            else
            {
                transform.localRotation = Quaternion.Euler(0, 0, 90);
            }
            
            
        }    
        if (vertical == 1)
        {
            if (henshin.x == -0.2f)
            {
                transform.localRotation = Quaternion.Euler(0, 0, 90);
            }
            else
            {
                transform.localRotation = Quaternion.Euler(0, 0, -90);
            }
            
        }
        
        //diagonal
        if(horizontal == 1 && vertical == 1)
        {
            
            henshin.x = -0.2f;
            transform.localRotation = Quaternion.Euler(0, 0, 45);
        }
        if (horizontal == 1 && vertical == -1)
        {
            henshin.x = -0.2f;
            
            transform.localRotation = Quaternion.Euler(0, 0, -45);
        }
        if (horizontal == -1 && vertical == -1)
        {
            henshin.x = 0.2f;
            transform.localRotation = Quaternion.Euler(0, 0, 45);
        }
        if (horizontal == -1 && vertical == 1)
        {
            henshin.x = 0.2f;
            transform.localRotation = Quaternion.Euler(0, 0, -45);
        }



    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("point"))
        {
            Destroy(collision.gameObject);
            score.AddScore(1);
            scoreText.text = "Score : " + score.nilai;
            

            StartCoroutine(Summon(collision.gameObject));
        }
    }

    IEnumerator Summon(GameObject prefab)
    {
        yield return new WaitForSeconds(3);
        Instantiate(point, new Vector2(Random.Range(6.32f, -6.32f), Random.Range(3.37f, -3.37f)), Quaternion.identity);
    }
}
