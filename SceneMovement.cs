using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMovement : MonoBehaviour
    {
    bool gameHasEnded = false;
    public float restartDelay = 1.5f;

    public void MoveScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    void ReturnScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void Exit()
    {
        Debug.Log("Exited");
        Application.Quit();
    }

    public void GameOver()
    {
        SceneManager.LoadScene("Game Over");
        //LoadSceneMode.Additive
        //^ added just in case needed
    }

    public void TitleScreenMove()
    {
        SceneManager.LoadScene("Title Screen");
    }

    public void MiniGameEnder()
    {
        SceneManager.LoadScene("Landing scene");
    }

    public void TaxiStart()
    {
        SceneManager.LoadScene("Psyche Taxi Stage");
    }

    public void TaxiInstructions()
    {
        SceneManager.LoadScene("Instructions for Taxi");
    }

    public void GambitStart()
    {
        SceneManager.LoadScene("Hangman's Gambit");
    }
 
    public void GambitInstructions()
    {
        SceneManager.LoadScene("Gambit Instructions");
    }

    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void EndGame() 
        { 
        if (gameHasEnded == false)
            {
                gameHasEnded = true;
                Debug.Log("game over");
                Invoke("GameOver", restartDelay);
            }
        }
    }
