using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FlappybaraScript : MonoBehaviour
{

    public Rigidbody2D myRigidbody;
    public float flappyStrength;

    public LogicScript logic;
    public bool IsAlive = true; 
    public float minHeight;
    public float maxHeight;
    private bool flappybaraJump;
    public AudioSource jumpSound;
    public AudioSource colisionSound;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    void Update()
    { 
        if (IsAlive)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Mouse0)) {
                flappybaraJump = true;
            } else {
                flappybaraJump = false;
            }

            if (flappybaraJump)
            {
                jumpSound.Play();
                myRigidbody.velocity = Vector2.up * flappyStrength;
            }

            if (gameObject.transform.position.y > maxHeight || gameObject.transform.position.y < minHeight)
            {
                endGame();
            }
        }

        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        endGame();
    }

     public void endGame()
    {
        if (IsAlive)
        {
            IsAlive = false;
            colisionSound.Play();
            logic.gameOver();
        }
        
    }

}
