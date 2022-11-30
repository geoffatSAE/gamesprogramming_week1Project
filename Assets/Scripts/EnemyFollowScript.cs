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
    float shootTimer;

    public GameObject missile;

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

                //check if they enter the volume
                if (volumeToMonitor.playerInsideVolume == true)
                {
                    //Player is inside the volume because the bool over there is true
                    enemyState = EnemyStates.chasing;

                }

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

                if(Vector3.Distance(player.transform.position, transform.position) < 10.0f)
                {
                    enemyState = EnemyStates.shooting;
                }

                //check if they've moved out of the volume
                if (volumeToMonitor.playerInsideVolume == false)
                {
                    //Player is inside the volume because the bool over there is true
                    enemyState = EnemyStates.idle;

                }

                break;


            case EnemyStates.shooting:
                //player is close to enemy, start shooting
                //


                //begin timer to shoot
                if(shootTimer >= 3.0f)
                {
                    //shoot
                    Debug.Log("pew pew pew");
                    //instantiate a missile 2 units in front of us (so we don't have it collide with us immediately)
                    Instantiate(missile,new Vector3(transform.localPosition.x, transform.localPosition.y, transform.localPosition.z + 2.0f), Quaternion.identity);

                    shootTimer = 0;
                } else
                {
                    shootTimer += Time.deltaTime;
                }

                //check if they've moved away
                if (Vector3.Distance(player.transform.position, transform.position) > 10.0f)
                {
                    enemyState = EnemyStates.chasing;
                }


                //check if they've moved out of the volume
                if (volumeToMonitor.playerInsideVolume == false)
                {
                    //Player is inside the volume because the bool over there is true
                    enemyState = EnemyStates.idle;

                }


                //

                break;

        }



        //update the value of my UI element with health
    }
}
