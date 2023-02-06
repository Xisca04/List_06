using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise_3 : MonoBehaviour
{
    // Countdown

    public int number = 10;

    private void Start()
    {
        for( int i = number; number >= 0; number--)
        {
            Debug.Log(number);
        }
    }
}
