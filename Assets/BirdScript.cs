using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public LogicScript logic;
    public bool birdIsAlive = true;
    private AudioSource flapSound;
    private Animator wingFlapAnimator;

    // Start is called before the first frame update
    private void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        wingFlapAnimator = GameObject.Find("Wing Flap").GetComponent<Animator>();
        flapSound = GetComponent<AudioSource>();
    }
    // Update is called once per frame
    private void Update()
    {
        bool shouldReceiveInput = birdIsAlive && LogicScript.canReceiveInput;

        if (shouldReceiveInput && Input.GetKeyDown(KeyCode.Space))
        {
            myRigidbody.velocity = Vector2.up * flapStrength;
            wingFlapAnimator.SetTrigger("Flap");
            if (LogicScript.isPaused == false)
            {
                        flapSound.Play();
            } 
        }

        if (transform.position.y > 18 || transform.position.y < -18)
        {
            birdIsAlive = false;
            logic.gameOver();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        birdIsAlive = false;
        logic.gameOver();    
    }
}
