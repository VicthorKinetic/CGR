using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class scr_Balde : MonoBehaviour {

    public GameObject Balde;
    public float velocidadePlayer = 1f;
    private int direcao = 0;
    public float limite = 2.3f;
    public int gotasobtidas = 0;
    public int gotastotal = 0;
    public scr_UI ui;
    public scr_Audio sons;



    // Use this for initialization
    void Start () {

        Balde = this.gameObject;
    }


    public void VerificaDirecao()
    {
        if (Input.GetKey(KeyCode.RightArrow))
            direcao = 1;
        else
           if (Input.GetKey(KeyCode.LeftArrow))
            direcao = -1;
        else
            direcao = 0;
    }

    public void LimpaBalde()
    {
        if (gotasobtidas == 10)
        {
            if (Input.GetKey(KeyCode.L))
            {
                gotasobtidas = 0;
            }
        }
    }

        // Update is called once per frame
        void Update()
        {

        VerificaDirecao();
        LimpaBalde();

        float posicaoX = transform.position.x;
        posicaoX += direcao * velocidadePlayer;

        posicaoX = Mathf.Clamp(posicaoX, limite * -1, limite);

        transform.position = new Vector3(posicaoX, transform.position.y, transform.position.z);

        }
        void OnCollisionEnter2D(Collision2D quem)
        {
            if(gotastotal == 30)
            {
                ui.VerificaSeAcabou();
                ui.txtGotasBalde.text = "Ganhou";
                ui.txtGotasTotal.text = "Ganhou";
                ui.txtGotasPerdidas.text = "Ganhou";
            }
        if (gotasobtidas == 10)
        {
            ui.VerificaSeAcabou();
            sons.vazamento.Play();
            Destroy(gameObject);
        }
        else
        {
            sons.gotaobtida.Play();
            Destroy(quem.gameObject);
            gotasobtidas++;
            gotastotal++;
        }
            
        }
}
