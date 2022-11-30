using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{

    public Transform target;
    public bool isHoming;
    public float speed;


    // Start is called before the first frame update
    void Start()
    {
        //find the player
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

        //face the player at the start
        transform.LookAt(target.position);

    }

    // Update is called once per frame
    void Update()
    {
        if (isHoming)
        {
            transform.LookAt(target.position);
        }


        //the rocket is lit, move forward
        transform.Translate(Vector3.forward * speed * Time.deltaTime);



    }

    private void OnCollisionEnter(Collision collision)
    {
        //we've hit something, explode
        Debug.Log("COLLISION BOOM, we hit " + collision.gameObject.tag);
        Destroy(gameObject);
    }
}
