using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCubeScript : MonoBehaviour
{

    public CounterCubeScript theCounterCube;
    float speed = 6.0f;
    public int coins = 0;

    // Start is called before the first frame update
    void Start()
    {
        theCounterCube = FindObjectOfType<CounterCubeScript>();
    }

    // Update is called once per frame
    void Update()
    {

        //theCounterCube.theCounter
        Debug.Log("The counter cube guy thing has " + theCounterCube.theCounter + " counts.");


        if (Input.GetButtonDown("Jump"))
        {
            Debug.Log("the jump has happened.");
            // set cube to red
            theCounterCube.SetLookOfThingToRed();
        }

        //
        //
        // Movement

        speed = 6.0f;

        //Player Movement Code
        //read the input of the horizontal and vertical, store them in a variabl
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        //Debug.Log("The vertical is " + verticalInput + " and the horizontal is " + horizontalInput);
        Vector3 inputFromPlayer = new Vector3(horizontalInput, 0, verticalInput);

        //move the player based on the values
        transform.Translate(inputFromPlayer * speed * Time.deltaTime);

    }
}
