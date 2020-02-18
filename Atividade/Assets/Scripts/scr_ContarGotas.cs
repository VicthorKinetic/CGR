using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class scr_ContarGotas : MonoBehaviour {

    public scr_Audio sons;
    public scr_Balde player;
    public scr_UI ui;

	// Use this for initialization
	void Start () {
	
	}

    public int chances = 0;
	
	// Update is called once per frame
	void Update () {

        
	
	}

    void OnCollisionEnter2D(Collision2D quem)
    {
        if (quem.gameObject.tag == "Enemy")
        {
            chances++;
            Destroy(quem.gameObject);

            if (chances == 10)
            {
                ui.VerificaSeAcabou();
                ui.txtGotasBalde.text = "Perdeu";
                ui.txtGotasTotal.text = "Perdeu";
                ui.txtGotasPerdidas.text = "Perdeu";
                sons.vazamento.Play();
                Destroy(player.Balde); 
            }
        }
    }
}
