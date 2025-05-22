using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class playerscript : MonoBehaviour
{
    public bool flag = true ;
    public Rigidbody2D box;
    public GameObject finish;
    // Start is called before the first frame update

    //public AudioSource src;
    //public AudioClip sfx;
 
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //src.clip = sfx;
        //src.Play();

        if (Input.GetKeyDown(KeyCode.Space) && flag)
        {
            box.gravityScale *= -1;
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        // Stop the box when it hits floor or ceiling
        if (collision.gameObject.name == "Floor" || collision.gameObject.name == "Ceiling" || collision.gameObject.name == "unique boy")
        {
            box.velocity = Vector2.zero;
        }

        if (collision.gameObject.CompareTag("Obstacle"))
        {
            box.gravityScale = 2f;
            flag = false;
            FindAnyObjectByType<gamemanager>().gameOver();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "finishline")
        {
            finish.SetActive(true);
        }
    }
}
