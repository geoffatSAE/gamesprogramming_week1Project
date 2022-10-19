using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private GameObject coin;

    public int gameLevel;

    // Start is called before the first frame update
    void Start()
    {
        //Instantiate(coin, new Vector3(-7f, 0f, 0.5f), Quaternion.identity);


        //1 dimension of coins
        for (int i = 0; i < 10; i++)
        {

            //int randomXValue = Random.Range(0, 10);
            
            Instantiate(coin, new Vector3(i, 0f, 0), Quaternion.identity);

        }

        
        //3 DIMENSIONS
        for (int i = 0; i < 10; i++)
        {
            for (int k = 0; k < 10; k++)
            {

                for (int j = 0; j < 10; j++)
                {
                    Instantiate(coin, new Vector3(i, j, k), Quaternion.identity);
                }

                
            }
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
