using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
    // Start is called before the first frame update


    // Update is called once per frame

    public AudioSource src;
    public AudioClip sfx;

    public void clicksound()
    {
        src.clip = sfx;
        src.Play();
    }
    public void play()
    {
        SceneManager.LoadScene("Game");
    }

    public void howToPlay()
    {
        SceneManager.LoadScene("How to play");
    }
    public void quit()
    {
        Application.Quit();
    }
}
