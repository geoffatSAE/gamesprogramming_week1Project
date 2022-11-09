using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MegamanFollow : MonoBehaviour
{
    public GameObject player;
    public float speed = 1;
    public GameObject mmSpriteGO;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //LookAt();
        Face();
       
    }

    private void LookAt()
    {

        //2D version of transform.LookAt(player.transform.position)
        //Look at the player position
        Quaternion rotation = Quaternion.LookRotation(player.transform.position - transform.position, transform.TransformDirection(Vector3.up));
        transform.rotation = new Quaternion(0, 0, rotation.z, rotation.w);

        MoveRight(1);
    }

    private void Face()
    {

        //x axis, are they in front or behind me
        float d = transform.position.x - player.transform.position.x;
              
        //
        if (d < 0)
        {
            //print("The other transform is behind me!");
            MoveRight(1);
            
            

        } else
        {
            MoveRight(-1);
            
        }
    }

    public void MoveRight(float backwards)
    {
        
        backwards = Mathf.Clamp(backwards, -1, 1);

        Debug.Log(backwards);
        //2D version of transform.Translate(Vector3.forward)
        //move right ('forward along X axis 1)
        transform.Translate(backwards * speed * Time.deltaTime, 0, 0);
        mmSpriteGO.transform.localScale = new Vector3(backwards, 1, 1);
    }

    public void MoveUp(float backwards)
    {
        float b2 = backwards;
        Mathf.Clamp(b2, -1, 1);

        Debug.Log(b2);
        //2D version of transform.Translate(Vector3.forward)
        //move right ('forward along X axis 1)
        transform.Translate(0, b2 * speed * Time.deltaTime, 0);
        mmSpriteGO.transform.localScale = new Vector3(b2, 1, 1);
    }
}
