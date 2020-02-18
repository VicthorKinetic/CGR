using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class Scr_VerificaWin : MonoBehaviour {

    public Scr_Paku Paku;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter2D(Collision2D quem)
    {
        if (quem.gameObject.tag == "Player")
        {
            if (Paku.coletados >= 9)
            {
                SceneManager.LoadScene("Ganhou");
            }
            else
            {
                SceneManager.LoadScene("Perdeu");
            }
        }

    }
}
