using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GambitDoor : MonoBehaviour {
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Player")
        {
            FindObjectOfType<SceneMovement>().GambitInstructions();
            Debug.Log("WRAH YOUVE BEEN GAMBIT'D(???)");
        }

    }
}
