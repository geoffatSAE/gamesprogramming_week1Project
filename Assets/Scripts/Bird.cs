using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : Animal
{

    public int wingSpan;


    // Start is called before the first frame update
    void Start()
    {
        //Eat();

        name = "robert";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            Eat();
        }
    }

    public override void Eat()
    {
        //base.Eat();
        Debug.Log("bird peck");
    }

    public void Flap()
    {


    }
}
