using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paletas : MonoBehaviour
{
    [SerializeField] private float velocidad = 7f;
    [SerializeField] private bool espaleta1;
    private readonly float yBound = 3.75f;

    void Update()
    {
        float movement;

        if(espaleta1)
        {
            movement = Input.GetAxisRaw("Vertical");
        }
        else 
        {
            movement = Input.GetAxisRaw("Vertical2");
            // me daba error esto por que habia puesto verticalw en unity y por eso no me funcionaba la paleta 2 xd
        }


        Vector2 paddleposition = transform.position;
        paddleposition.y = Mathf.Clamp(paddleposition.y + movement * velocidad * Time.deltaTime, -yBound, yBound);
        transform.position = paddleposition;
    }
}
