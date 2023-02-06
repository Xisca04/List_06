using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise_1 : MonoBehaviour
{
    // Even numbers 0 to 100 in descending mode

    private void Start()
    {
        for(int i = 100; i >= 0; i -= 2)
        {
            Debug.Log(i);
        }
    }
}
