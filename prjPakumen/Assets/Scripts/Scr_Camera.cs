using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Scr_Camera : MonoBehaviour {

    public float velocidadeCamera = 3;
    Rigidbody2D cameraMatadora;
    public Scr_Paku Paku;
    public Scr_Audio sons;

	// Use this for initialization
	void Start () {

        cameraMatadora = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {

        if (this.enabled)
        {
            if (cameraMatadora.position.x <= 59.6)
            {
                cameraMatadora.velocity = new Vector2(velocidadeCamera, 0);

            }

            else
            {
                this.enabled = false;
                cameraMatadora.velocity = new Vector2(0, 0);
            }
        }

	}

    void OnCollisionEnter2D (Collision2D quem)
    {
        if (this.enabled)
        {
            if (quem.gameObject.tag == "Player")
            {
                Destroy(quem.gameObject);
                velocidadeCamera = 0;
                sons.Music.Stop();
                SceneManager.LoadScene("Perdeu");

            }
        }
    }
}
