using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class mover : MonoBehaviour {


    void Start (){       
    }

    void Update () {        
    }


    private void OnCollisionStay (Collision col) {
        if (col.gameObject.tag == "Player" && Input.GetKey(KeyCode.Space)) {

            if(transform.position.x >= col.transform.position.x)
            {
            	transform.position = new Vector3(transform.position.x + 1, transform.position.y, transform.position.z);
            }

            else if(transform.position.x < col.transform.position.x)
            {
            	transform.position = new Vector3(transform.position.x - 1, transform.position.y, transform.position.z);
            }

            if(transform.position.z >= col.transform.position.z)
            {
            	transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 1);
            }

            else if(transform.position.z < col.transform.position.z)
            {
            	transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - 1);
            }
        }
    }
}