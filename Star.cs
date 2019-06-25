using UnityEngine;

public class Star : MonoBehaviour {
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Star")
        {
            FindObjectOfType<Timer>().AddTime();
            collisionInfo.gameObject.SetActive(false);
        }

    }
}
