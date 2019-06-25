using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PsycheTaxiDoor : MonoBehaviour {
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Player")
        {
            FindObjectOfType<SceneMovement>().TaxiInstructions();
            Debug.Log("WRAH YOUVE BEEN TAXI'D");
        }
            
    }
}
