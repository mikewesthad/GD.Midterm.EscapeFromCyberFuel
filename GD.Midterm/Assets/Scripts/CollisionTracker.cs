using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollisionTracker : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] ParticleSystem fire;
    [SerializeField] Text GameOverText;
    PlayerController playerController;
    Rigidbody playerRb;
    bool gameOver;
    private void Awake()
    {
        fire.Stop();
    }
    void Start()
    {
        playerController = GetComponent<PlayerController>();
        playerRb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gameOver == true)
        {
            playerRb.useGravity = true;
            
            playerController.enabled = false;
            GameOverText.text = "Game over!";
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(gameObject.tag == "Player" && collision.gameObject.tag == "Obstacle")
        {
            fire.Play();
            gameOver = true;
        }
    }
}
