using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CounterCubeScript : MonoBehaviour
{
    public int theCounter;
    //int i = 10;
    public PlayerCubeScript thePlayerScript;

    public enum Coin { Yellow, Red };
    public Coin myCoinType;

    Renderer r;

    public int coinValue;

    // Start is called before the first frame update
    void Start()
    {
        r = GetComponent<Renderer>();
        r.material.color = Color.blue;

        switch (myCoinType)
        {
            case Coin.Yellow:
                //we are a yellow coin so
                coinValue = 1;
                r.material.color = Color.yellow;
                break;

            case Coin.Red:
                coinValue = 10;
                r.material.color = Color.red;
                break;

        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetLookOfThingToRed()
    {
        r.material.color = Color.red;
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("something had entered the trigger, and it was " + other.name);

        if(other.name == "PlayerCube")
        {
            //it was the player that has entered the countercube
            Debug.Log("player has entered the counter cube dun duhhh");

            //we want to add to the playercube's script that has the coin count
            //
            //get a reference to the player cubes player script
            thePlayerScript = other.gameObject.GetComponent<PlayerCubeScript>();

            // add to the value of coins collected on the player script
            thePlayerScript.SetIncreaseCoins(coinValue);
        }
    }


}
