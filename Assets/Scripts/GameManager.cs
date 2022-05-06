using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    SceneManager sceneManager;
    bool gameHasEnded = false;
    public void EndGameFromCollision()
    {
        if(gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over!");
        }
        Invoke("Restart", 1.5f);
    }
    public void EndGameFromFalling()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over!");
        }
        Restart();
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
