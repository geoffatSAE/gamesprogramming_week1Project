using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerSprite : MonoBehaviour
{
    public Animator myAnimator;
    public GameObject mySprites;

    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        //myAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(h, v * speed, 0) * speed * Time.deltaTime);

        if(h <= 0)
        {
            //moving left
            //If i am using the animator to control
            //myAnimator.SetBool("Right", false);

            //if I am using the scale to control the animation direction
            mySprites.transform.localScale = new Vector3(1, 1, 1);

        } else
        {
            //moving right
            //myAnimator.SetBool("Right", true);
            mySprites.transform.localScale = new Vector3(-1, 1, 1);


        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("collision with : " + collision.gameObject.name);
    }
}
