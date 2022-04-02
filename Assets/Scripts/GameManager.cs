using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 1f;
    public GameObject completeLevelUI;
    public GameObject score;
    public GameObject nextLevel;
    public GameObject quit;
    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
        score.SetActive(false);
        nextLevel.SetActive(true);
        quit.SetActive(true);

    }

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Invoke("Restart", 2f);
        }
       
    }
 
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
