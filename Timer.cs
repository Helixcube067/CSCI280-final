using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
    public Text timerText;
    private int timer;
    public int setTime = 500;
    public int addedTime;

    // Use this for initialization
    void Start() {
        timer += setTime;
    }

    // Update is called once per frame
    void Update() {
        timer--;
        timerText.text = timer.ToString("Timer: " + timer);
        if (timer == 0)
        {
            FindObjectOfType<SceneMovement>().EndGame();
        }
    }

    public void AddTime(){
        timer = timer + addedTime;
    }
}
