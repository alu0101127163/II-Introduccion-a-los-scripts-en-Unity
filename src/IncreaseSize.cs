using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class IncreaseSize : MonoBehaviour {

    Character_Controller player; // Reference to the player cube

   
    void Start() {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Character_Controller>();
    }

    void Update () {
    }


    private void OnCollisionStay(Collision col) {
        if (col.gameObject.tag == "Player") {
           transform.localScale += new Vector3 (1,1,1);
           player.points++;
        }
    }
}