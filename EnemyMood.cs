using UnityEngine;
using UnityEngine.UI;

public class EnemyMood : MonoBehaviour {
    private int lives = 3;
    public Text livesText;
    public GameObject enemy;
    public float delayer;
    public DoorBreaker reaffirmer;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Player")
        {
            if (lives >= 1)
            {
                lives--;
                this.gameObject.SetActive(false);
                Invoke("Replacement", delayer);
            }

            else
            {
                FindObjectOfType<SceneMovement>().GameOver();
            }
        }
    }

    void Update()
    {
        livesText.text = lives.ToString("Lives: " + lives);
    }

    public void Replacement()
    {
        if ((reaffirmer.GetKillCount()) < 5)
        {
            //int why = Random.Range(0, 5);
            int ex = Random.Range(-6, 6);
            int zed = Random.Range(-10, 10);
            Instantiate(enemy, new Vector3(ex, 5, zed), Quaternion.identity);
            enemy.SetActive(true);
        }
    }

    void OnMouseDown()
    {
        enemy.SetActive(false);
        Invoke("Replacement", delayer);
        FindObjectOfType<DoorBreaker>().AddKill();
    }
}
