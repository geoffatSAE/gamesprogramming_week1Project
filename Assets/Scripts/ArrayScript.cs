using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayScript : MonoBehaviour
{
    string[] fruit;

    // Start is called before the first frame update
    void Start()
    {
        
        fruit = new string[9];

        fruit[0] = "banana";
        fruit[1] = "apple";
        fruit[2] = "orange";
        fruit[3] = "cake";
        fruit[4] = "grape";
        fruit[5] = "grape";
        fruit[6] = "grape";
        fruit[7] = "grape";
        fruit[8] = "more grapes";

        for (int i = 0; i < fruit.Length; i++)
        {
            //inside the loop
            Debug.Log(fruit[i]);
        }

        //Debug.Log(fruit[randomNumber]);
        int k = 0;

        while (k > 10)
        {
            //loop this
            Debug.Log("something is true");

            k++;
        }

        int f = 0;
        do
        {
            Debug.Log("something is true but do while");
            f++;

        } while (f > 10);

    }

    // Update is called once per frame
    void Update()
    {

        
    }
}
