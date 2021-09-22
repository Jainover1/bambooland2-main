using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class llave : MonoBehaviour
{
    public float pickup;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   public void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject objeto = collision.gameObject;
        string etiqueta = objeto.tag;
        if(etiqueta == "Player")
        {
            recoger();
        }
    }
    public void recoger()
    {
        pickup--;
            if (pickup == 0)
            {
                Destroy(this.gameObject);
               (GameObject.Find("muro").GetComponent<muro>()).destruir();
        }
    }
}
