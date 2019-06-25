using UnityEngine;
using UnityEngine.UI;

public class DoorBreaker : MonoBehaviour
{
    public Text killText;
    private int killCount;
    public GameObject door;

    void Update()
    {
        killText.text = killCount.ToString("Kills: " + killCount);
        if (killCount == 5)
        {
            Destroy(door);
        }
    }

    public void AddKill()
    {
        killCount++;
        Debug.Log(killCount);
    }

    public int GetKillCount()
    {
        return killCount;
    }
}