using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alejar : MonoBehaviour
{
	  Character_Controller player; // Reference to the player cube

    // Start is called before the first frame update
    void Start()
    {
      player = GameObject.FindGameObjectWithTag("Player").GetComponent<Character_Controller>();

    }

    // Update is called once per frame
    void Update()
    {

    	 float dist = Vector3.Distance(transform.position, player.transform.position);
    	 //Debug.Log(dist);

    	 if(dist < 100)
    	  {
    	 	if(transform.position.x >= player.transform.position.x)
            {
            	transform.position = new Vector3(transform.position.x + 1, transform.position.y, transform.position.z);
            }

            else if(transform.position.x < player.transform.position.x)
            {
            	transform.position = new Vector3(transform.position.x - 1, transform.position.y, transform.position.z);
            }

            if(transform.position.z >= player.transform.position.z)
            {
            	transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 1);
            }

            else if(transform.position.z < player.transform.position.z)
            {
            	transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - 1);
            }
          }
        
    }
}
