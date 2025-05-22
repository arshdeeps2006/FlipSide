using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class howtoplay : MonoBehaviour
{
    public AudioSource src;
    public AudioClip sfx;

    public void clicksound()
    {
        src.clip = sfx;
        src.Play();
    }
    public void back()
    {
        SceneManager.LoadScene("Menu");
    }
}
