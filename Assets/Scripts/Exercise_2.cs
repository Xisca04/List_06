using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise_2 : MonoBehaviour
{
    // Display a message 20 times 

    private int i = 1;

    private void Start()
    {
        while(i <= 20)
        {
            Debug.Log($"Hola, holita, vecinito");
            i++;
        }
    }
}
