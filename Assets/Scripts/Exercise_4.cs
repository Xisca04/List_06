using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise_4 : MonoBehaviour
{
    // All multiples of 5 between the start and the end

    public int start;
    public int end;

    private void Start()
    {
        if(start <= end)
        {
            Debug.Log(start);
            start += 5;
        }
    }
}
