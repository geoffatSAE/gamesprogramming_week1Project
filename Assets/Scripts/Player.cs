using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int coinsCollected = 0; //declared and assigned in a single line
    private float speed;
    public bool tutorialComplete;
    public int playerLevel;

    // Start is called before the first frame update
    void Start()
    {
        //coinsCollected = 0;
        speed = 3.2f;

        //horizontalInput = 6.0f;
    }

    // Update is called once per frame
    void Update()
    {
        speed = 6.0f;

        //Player Movement Code
        //read the input of the horizontal and vertical, store them in a variabl
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        //Debug.Log("The vertical is " + verticalInput + " and the horizontal is " + horizontalInput);
        Vector3 inputFromPlayer = new Vector3(horizontalInput, 0, verticalInput);

        //move the player based on the values
        transform.Translate(inputFromPlayer * speed * Time.deltaTime);
        //
        //
        //If statement equality tests
        //
        // == are exactly the same
        // < is less than
        // > is greater than
        // <= is less than or equal to
        // >= is greater than or equal to
        // != is NOT equal to
        // 

        //picked up a coin from something
        //all three of these add 1 coin
        
        //using the return function to test if something is true
        
        //using the return function to assign a value
        //CollectedCoin(1);

        //coinsCollected++;
        //coinsCollected = coinsCollected + 1;
        

        //picking up a bundle of coins
        //CollectedCoin(4);

        //player traded some coins
        //CollectedCoin(5);




        if (coinsCollected == 1)
        {
            //is true, do some code
            //Debug.Log("its TRUEEEEEEEEEEEEEEEEEEEEEE, we have 1 coins now");
        } else
        {
            //Debug.Log("it wasnt true after all, we have 0 coins");
        }



        coinsCollected = 1;
        
        //OR example
        if(coinsCollected == 1 || coinsCollected == 2)
        {

            //Debug.Log("we have 1 or 2 coins, but not 0 or 3+");
        } else
        {
            //Debug.Log("we have 0 or 3+ coins, but not 1 or 2");

        }

       
        ///
        /// AND example 
        if (coinsCollected == 1 && tutorialComplete == true && speed > 3.0f)
        {
            //
            //Debug.Log("have 1 coin, and tutorial is complete (true)");

        } else
        {
            //Debug.Log("either we dont have 1 coin, or the tutorial is not complete");
        }

        ///
        ///If Else If example
        if (coinsCollected == 0)
        {
            //we have 0

        } else if (coinsCollected == 1)
        {
            //we have 1 coins
        } else
        {
            //we have not 0 or 1 coins (so 2+, or minus)
        }


    }

    public void CollectedCoin(int numberOfCoinsCollectedInThisAction)
    {
        coinsCollected += numberOfCoinsCollectedInThisAction;
        if(coinsCollected == 15)
        {
            //player has collected enough coins to level up
            playerLevel += 1;
        }

    }


    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Log("collision has happened eh, and it was " + collision.gameObject.name);

        if(collision.gameObject.name == "Wall")
        {
            //We hit the wall!!
            

        }
        
    }

    private void OnCollisionExit(Collision collision)
    {
        //Debug.Log("collision has ended with " + collision.gameObject.name);
    }
}
