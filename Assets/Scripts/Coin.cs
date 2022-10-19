using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 100*Time.deltaTime, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("something has entered the trigger, and it was " + other.gameObject.name);

        if(other.gameObject.name == "MyCube")
        {
            Debug.Log("player has entered the trigger, the coin is collected");
            Destroy(gameObject, 0.5f);

            //add a coin to the player
            other.gameObject.GetComponent<Player>().CollectedCoin(1);
            
        }

    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("still inside!!!");
    }
}
