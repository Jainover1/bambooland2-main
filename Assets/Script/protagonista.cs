using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class protagonista : MonoBehaviour
{
    public float speed;
    public float altura;
    public float tiempoSalto;
    float salto;
    private Rigidbody2D MyRb;
    // Start is called before the first frame update
    void Start()
    {
        MyRb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
        movimiento();
        if (Input.GetKeyDown(KeyCode.Space) && Time.time >= salto)
        {
            MyRb.velocity = new Vector2(MyRb.velocity.x, altura);
            salto = Time.time + tiempoSalto;
        }

    }
    public void movimiento()
    {
        float Hori = Input.GetAxis("Horizontal");
        if (Hori > 0.1f)
        {
            Vector2 caminar = new Vector2(Hori * Time.deltaTime * speed, 0);
            transform.eulerAngles = new Vector3(0, 0, 0);
            transform.Translate(caminar);
        }
        if (Hori <= 0)
        {
            Vector2 caminar = new Vector2(-Hori * Time.deltaTime * speed, 0);
            transform.eulerAngles = new Vector3(0, 180, 0);
            transform.Translate(caminar);
        }
        if (Hori == 0)
        {
            Vector2 caminar = new Vector2(0f, 0f);
            transform.Translate(caminar);
        }


    }
}
