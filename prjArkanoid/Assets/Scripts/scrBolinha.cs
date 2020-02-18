using UnityEngine;
using System.Collections;

public class scrBolinha : MonoBehaviour {

    Rigidbody2D corpo2DBola;

    // Use this for initialization
    void Start()
    {
        corpo2DBola = GetComponent<Rigidbody2D>();
        corpo2DBola.velocity = new Vector2(1.5f, -7f);
    }
    
    // Update is called once per frame
    void Update()
    {
        if (corpo2DBola.velocity.y > 0)
            corpo2DBola.velocity = new Vector2(corpo2DBola.velocity.x, 7f);
        else
            corpo2DBola.velocity = new Vector2(corpo2DBola.velocity.x, -7f);

        if (corpo2DBola.velocity.x > 15f)
            corpo2DBola.velocity = new Vector2(15f, corpo2DBola.velocity.y);
    }
    
    //void OnCollisionEnter2D(Collision2D quem)
    //{
    //    if (quem.gameObject.tag == "Player")
    //    {
    //        float velX = corpo2DBola.velocity.x;
    //        float velY = corpo2DBola.velocity.y;
    //        velX = quem.gameObject.GetComponent<Rigidbody2D>().velocity.x /3 ;
    //        corpo2DBola.velocity = new Vector2(velX, velY);
    //    }
    //}
}
