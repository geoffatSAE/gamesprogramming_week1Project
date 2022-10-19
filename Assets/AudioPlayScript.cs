using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayScript : MonoBehaviour
{
    AudioSource myAudio;


    // Start is called before the first frame update
    void Start()
    {
        myAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        //check its the player
        if(other.tag == "Player")
        {

            //if i need to stop audio playing
            myAudio.Stop();

            //check if audio is already playing
            if (myAudio.isPlaying == false)
            {
                //audio
                myAudio.Play();
            }

            //set a parameter such as if I should be looping, true or false
            myAudio.loop = false;

        }
    }
}
