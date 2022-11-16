using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollowScript : MonoBehaviour
{
    public GameObject player;
    public VolumeDetection volumeToMonitor;
    public float speed = 1;
    bool chasePlayer;
    float health;

    public enum EnemyStates {  idle, chasing, shooting }
    public EnemyStates enemyState;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        volumeToMonitor = GameObject.FindGameObjectWithTag("VolumeDetector").GetComponent<VolumeDetection>();
    }

    // Update is called once per frame
    void Update()
    {

        switch (enemyState)
        {
            case EnemyStates.idle:
                //enemy is idle, do idle things
                //
                break;

            case EnemyStates.chasing:
                //enemy can see player, chase code
                //
                //glare at the player
                transform.LookAt(player.transform.position);
                //run after him
                transform.Translate(Vector3.forward * speed * Time.deltaTime);
                
                //check if my distance from the player is below 10, then set to shooting.
                //
                break;


            case EnemyStates.shooting:
                //player is close to enemy, start shooting
                //
              break;

        }


        //set the correct state
        if(volumeToMonitor.playerInsideVolume == true)
        {
            //Player is inside the volume because the bool over there is true
            enemyState = EnemyStates.chasing;

        } else
        {
            enemyState = EnemyStates.idle;
        }

        //update the value of my UI element with health
    }
}
