using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cheetah : Animal
{
    public float maxSpeed;

    // Start is called before the first frame update
    void Start()
    {
        name = "zoom zoom";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            Eat();
        }
    }

    public void Run()
    {
        Debug.Log("running");

    }
}
