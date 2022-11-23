using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterScript : MonoBehaviour
{
    public GameObject myCamera;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButton("Fire1"))
        {
            Debug.Log("Bang bang");

            //get the forward direction 10 units from the camera
            Vector3 forward = myCamera.transform.TransformDirection(Vector3.forward) * 10;

            //draw a line
            Debug.DrawRay(myCamera.transform.position, forward, Color.red);

            //save a raycast to store the hit data
            RaycastHit hit;

            //raycast out, if we hit something return it to hit
            if (Physics.Raycast(myCamera.transform.position, forward, out hit))
            {
                Debug.Log("hit the " + hit.collider.gameObject.name);

                //grab their Damage script
                Damage enemyDamage =  hit.collider.gameObject.GetComponent<Damage>();
                if (enemyDamage) //;check we got it and don't error
                    enemyDamage.TakeDamage(); //call their damage script
                
            }

        }

    }
}
