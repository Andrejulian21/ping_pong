using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nomeacuerdo : MonoBehaviour
{
    [SerializeField] private float initialVelocity = 5.5f;
    [SerializeField] private float velocitymulplier = 1.6f;
    private Rigidbody2D pollorb;
    void Start()
    {
       pollorb = GetComponent<Rigidbody2D>();
        launch();
    }
    private void launch()
    {
        float xVelocity = Random.Range(0, 2) == 0 ? 1 : -1;
        float yVelocity = Random.Range(0, 2) == 0 ? 1 : -1;
        pollorb.velocity = new Vector2(xVelocity, yVelocity) * initialVelocity;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Muslo"))
        {
            pollorb.velocity *= velocitymulplier;
        }


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("goal 1"))
        {
            gamemanager.Instance.Puntuación2();
            gamemanager.Instance.Restart();
            launch();
        }
        else
        {
            gamemanager.Instance.Puntuación1();
            gamemanager.Instance.Restart();
            launch();
        }

    }
    
}
