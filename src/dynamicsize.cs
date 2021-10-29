using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dynamicsize : MonoBehaviour
{

		Character_Controller player; // Reference to the player cube
	  Character_Controller2 bola; // Reference to the player cube


    // Start is called before the first frame update
    void Start()
    {
       player = GameObject.FindGameObjectWithTag("Player").GetComponent<Character_Controller>();
       bola = GameObject.FindGameObjectWithTag("Bola").GetComponent<Character_Controller2>();
    }

    // Update is called once per frame
    void Update()
    {
        float dist_player = Vector3.Distance(transform.position, player.transform.position);
        float dist_bola = Vector3.Distance(transform.position, bola.transform.position);

    	 //Debug.Log(dist);

    	 if(dist_bola < 100)
    	 {
    	  transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y, transform.localScale.y) * 1.005f;
    	 }
    	 if(dist_player < 150)
    	 {
    	  transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y, transform.localScale.y) * 0.99f;
    	 }
    }
}
