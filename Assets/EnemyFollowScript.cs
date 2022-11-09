using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollowScript : MonoBehaviour
{
    public GameObject player;
    public VolumeDetection volumeToMonitor;
    public float speed = 1;
    bool chasePlayer;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        volumeToMonitor = GameObject.FindGameObjectWithTag("VolumeDetector").GetComponent<VolumeDetection>();
    }

    // Update is called once per frame
    void Update()
    {
        if(volumeToMonitor.playerInsideVolume == true)
        {
            //Player is inside the volume because the bool over there is true
            //glare at the player
            transform.LookAt(player.transform.position);
            //run after him
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
    }
}
