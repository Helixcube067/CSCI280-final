using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {
    public Progressive progressCheck;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Player")
        {
            if (progressCheck.Entry())
            {
                FindObjectOfType<SceneMovement>().Credits();
                Debug.Log("Only cool kids allowed. Good thing you're cool");
            }
            else {
                Debug.Log("ONLY COOL KIDS ALLOWED!!!");
            }
        }
    }
}
