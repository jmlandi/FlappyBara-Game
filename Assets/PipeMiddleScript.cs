using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{

    public LogicScript logic;
    public AudioSource middleAudio;

    public FlappybaraScript flappybara;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        flappybara = GameObject.FindGameObjectWithTag("Flappybara").GetComponent<FlappybaraScript>();
        
    }

    void Update()
    {

    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3 && flappybara.IsAlive) {
            logic.addScore(1);
            middleAudio.Play();
        }
    }
}
