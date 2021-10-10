using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    private Text scoreText;

    public static int nilai = 0;

    public static void AddScore(int value)
    {
        nilai += value;
    }
   
}
