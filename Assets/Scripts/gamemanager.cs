using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gamemanager : MonoBehaviour
{

    public GameObject gameOverScreen;
    public GameObject Endgame;

    public AudioSource musicSource;

    void Start()
    {
        Invoke("StartMusic", 65f); // delay for 40 seconds
    }

    void StartMusic()
    {
        musicSource.Play();
    }
    public void EndGame()
    {
        Endgame.SetActive(true);
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); 
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }

    public void menu()
    {
        SceneManager.LoadScene("Menu");
    }

}
