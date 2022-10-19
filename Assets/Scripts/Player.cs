using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public int coinsCollected = 0; //declared and assigned in a single line
    private float speed;
    public bool tutorialComplete;
    public int playerLevel;
    public Transform spawnPoint;

    public GameObject myObjectToSpawn;
    //public Text coinUIText;

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
        //read the input of the horizontal and vertical, store them in a variable
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        //Debug.Log("The vertical is " + verticalInput + " and the horizontal is " + horizontalInput);
        Vector3 inputFromPlayer = new Vector3(horizontalInput, 0, verticalInput);

        //move the player based on the values
        transform.Translate(inputFromPlayer * speed * Time.deltaTime);
        //

        //no longer updating UI from the player script, refer to the UI Manager
        //coinUIText.text = "Coins: " + coinsCollected.ToString();

        if (Input.GetButtonDown("Jump"))
        {
            Instantiate(myObjectToSpawn, spawnPoint.position, Quaternion.identity);
        }

    }

    public void CollectedCoin(int numberOfCoinsCollectedInThisAction)
    {
        coinsCollected += numberOfCoinsCollectedInThisAction;
        if(coinsCollected == 5)
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
