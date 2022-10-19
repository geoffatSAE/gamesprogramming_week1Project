using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManagerScript : MonoBehaviour
{
    public Text coins, level;
    public Player myPlayer;
    public GameManager myGM;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Grab coing from the player, and put it in ui
        coins.text = "Coins: " + myPlayer.coinsCollected.ToString();


        //grab level from Game Manager and put it in the ui
        level.text = "Level " + myGM.gameLevel.ToString();
    }
}
