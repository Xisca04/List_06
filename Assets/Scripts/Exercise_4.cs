using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise_4 : MonoBehaviour
{
    // All multiples of 5 between the start and the end

    public int start;
    public int end;
    private int multipler = 5;

    private void Start()
    {
        while(start <= end)
        {
            if(start % multipler == 0)
            {
                Debug.Log(start);
            }

            start++;
        }
    }
}
