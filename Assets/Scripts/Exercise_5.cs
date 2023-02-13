using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise_5 : MonoBehaviour
{
    // Sum of the elements of the array

    public int[] sum = { 1, 2, 3, 4, 5 };
    private int result;

    void Start()
    {
        foreach(int number in sum)
        {
           result += number;
        }
        Debug.Log(result);
    }

}
