using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    [Range(1, 10)]
    public float velocidad;
    [Range(1, 500)]
    public float potenciaSalto;
    Rigidbody2D rb2d;
    SpriteRenderer spRd;
    bool isJumping = false;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        spRd = GetComponent<SpriteRenderer>();

    }

    void FixedUpdate()
    {

        //Movimiento horizontal
        float movimientoH = Input.GetAxisRaw("Horizontal");
        rb2d.velocity = new Vector2(movimientoH * velocidad, rb2d.velocity.y);

        //Sentido horizontal
        if (movimientoH > 0)
        {
            spRd.flipX = false;
        }
        else if (movimientoH < 0)
        {
            spRd.flipX = true;
        }

        //Si pulso la tecla de salto (espacio) y no estaba saltando
        if (Input.GetButtonDown("Jump") && !isJumping)
        {
            //Le aplico la fuerza de salto
            rb2d.AddForce(Vector2.up * potenciaSalto);
            //Digo que está saltando
            isJumping = true;
        }

    }

    private void OnCollisionEnter2D(Collision2D other)
    {

        //Si el jugador colisiona con un objeto con la etiqueta suelo
        if (other.gameObject.CompareTag("Suelo"))
        {
            //Digo que no está saltando
            isJumping = false;
            //Le quito la fuerza de salto remanente que tuviera
            rb2d.velocity = new Vector2(rb2d.velocity.x, 0);

        }

    }

}