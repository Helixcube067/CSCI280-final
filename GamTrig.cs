using UnityEngine;

public class GamTrig : MonoBehaviour {
    public PlayerMove player;
    public SceneMovement gameManager;
    public Progressive decider;
    public float delayer;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Player")
        {
            OnTriggerEnter();
        }
    }

    void OnTriggerEnter()
    {
        //can be used to move the scene forward or backwards
        //commenting the backwards function and keeping the forwards scene movement.
        //note: may have to make a duplicate to separate these functionalities
        player.enabled = false;
        Debug.Log("Meowdy Pawdna");
        Invoke("SpecializedMove", delayer);
    }
    private void SpecializedMove()
    {
        gameManager.MiniGameEnder();
        decider.GetSecondKey();
    }
}
