using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrabbyMove : MonoBehaviour
{
    public GameObject mmSpriteGO;
    public GameObject player;
    public float speed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Chase();
    }

    private void Chase()
    {

        //x axis, are they in front or behind me
        float d = transform.position.x - player.transform.position.x;
        //
        if (d < 0)
        {
            //print("The other transform is behind me!");
            MoveRight(1);
            //transform.Translate(1 * speed * Time.deltaTime, 0, 0);

        }
        else
        {
            MoveRight(-1);
            //transform.Translate(-1 * speed * Time.deltaTime, 0, 0);
        }

        float y = transform.position.y - player.transform.position.y;
        //
        if (y < 0)
        {
            MoveUp(1);
        }
        else
        {
            MoveUp(-1);
        }
    }

    public void MoveRight(float moveVal)
    {
        //do some error checking to make sure its a 1 or -1
        moveVal = Mathf.Clamp(moveVal, -1, 1);

        //move the guy in direction x (axis) times speed per second
        transform.Translate(moveVal * speed * Time.deltaTime, 0, 0);

        //set the sprites facing value to right
        //(as -negative, if its opposite remove the -)
        mmSpriteGO.transform.localScale = new Vector3(-moveVal, 1, 1);
    }

    public void MoveUp(float moveVal)
    {
        //do some error checking to make sure its a 1 or -1
        moveVal = Mathf.Clamp(moveVal, -1, 1);

        //move the guy in direction y (axis) times speed per second
        transform.Translate(0, moveVal * speed * Time.deltaTime, 0);
        
    }
}
