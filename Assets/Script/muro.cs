using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class muro : MonoBehaviour
{

    public float bloqueo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
    }
   public void destruir()
    {
        bloqueo--;
        if(bloqueo == 0)
        {
            Destroy(this.gameObject);
        }
    }
}
