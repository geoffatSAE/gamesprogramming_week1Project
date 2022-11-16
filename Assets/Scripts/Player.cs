using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public int coinsCollected = 0; //declared and assigned in a single line
    private float speed, rotateSpeed;
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
        rotateSpeed = 100.0f;
        //horizontalInput = 6.0f;
    }

    // Update is called once per frame
    void Update()
    {
        speed = 6.0f;

        // call the movement function
        //PlayerMovementPokemonStyle();
        PlayerMovementTankStyle();


        //no longer updating UI from the player script, refer to the UI Manager
        //coinUIText.text = "Coins: " + coinsCollected.ToString();

        if (Input.GetButtonDown("Jump"))
        {
            GameObject bullet = Instantiate(myObjectToSpawn, spawnPoint.position, Quaternion.identity) as GameObject;
            Rigidbody r = bullet.GetComponent<Rigidbody>();
            
            bullet.transform.rotation = Quaternion.Euler(new Vector3(0, 90, 0));
            Debug.Break();
            r.AddRelativeForce(Vector3.forward * 1000);
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

    public void PlayerMovementPokemonStyle()
    {

        //Player Movement Code
        //read the input of the horizontal and vertical, store them in a variable
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        //Debug.Log("The vertical is " + verticalInput + " and the horizontal is " + horizontalInput);
        Vector3 inputFromPlayer = new Vector3(horizontalInput, 0, verticalInput);

        //move the player based on the values
        transform.Translate(inputFromPlayer * speed * Time.deltaTime);
        //
    }

    public void PlayerMovementTankStyle()
    {
        //Player Movement Code
        //read the input of the horizontal and vertical, store them in a variable
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        transform.Rotate(0, horizontalInput * Time.deltaTime * rotateSpeed, 0);

        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);

    }
}
