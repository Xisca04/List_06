using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise_5 : MonoBehaviour
{
    // Sum of the elements of the array

    public int[] sum;
    private int result;

    void Start()
    {
        foreach(int item in sum)
        {
           result += item;
           Debug.Log(result);
        }
    }

}
