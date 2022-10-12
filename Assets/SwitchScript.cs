using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchScript : MonoBehaviour
{
    //if its 1 = red, 2 = blue, 3 = green
    //public int colourOfTheCube;

    public enum ColourOfCube { red, green, blue };
    public ColourOfCube myColOfCube;

    public enum AIbehaviour {  idle, patrolling, seeking, attacking };
    public AIbehaviour myAIBehaviour;

    Renderer r;
    // Start is called before the first frame update
    void Start()
    {
        r = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {

        switch (myAIBehaviour)
        {
            case AIbehaviour.idle:
                //ai is going to sit here and look around and eat an apple
                Debug.Log("im idle ");
                break;

            case AIbehaviour.patrolling:
                //ai moves between the two patrol points

                //Function call, check if the player is right in front of me
                
                //if (i've just seen the player)
                //myAIBehaviour = AIbehaviour.patrolling;


                break;

            case AIbehaviour.seeking:
                //ai is chasing the player

                break;

            default:
                break;

        }






        switch (myColOfCube)
        {
            case ColourOfCube.red:
                r.material.color = Color.red;
                break;

            case ColourOfCube.blue:
                r.material.color = Color.blue;
                break;

            case ColourOfCube.green:
                r.material.color = Color.green;
                break;

            default:
                r.material.color = Color.black;
                break;
        }

    }
}
