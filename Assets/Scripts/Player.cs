using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private string prev_type = "basic";

    void Start()
    {

     
    }

    void OnPlayerLose(GameObject player)
    {
        if (player == gameObject)
        {
            // loseAnim.Play();
            // switchCharacter(this, scene.characters);
            // if (scene.state != States.GameState.GAME_OVER)
            // {
            //     scene.resetRound();
            // }
        }
    }

    void Update() {

    }

    private void Awake() {
        
    }
}
