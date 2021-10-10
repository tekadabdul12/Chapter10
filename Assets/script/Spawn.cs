using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject point;
    float randvert, randhoriz, randtotal;

    private void Start()
    {
        randtotal = Random.Range(6, 15);
        for(int i = 0; i < randtotal; i++)
        {
            randvert = Random.Range(3.4f, -3.4f);
            randhoriz = Random.Range(8f, -8f);

            Instantiate(point, new Vector2(randhoriz, randvert),Quaternion.identity);
        }
    }
}
