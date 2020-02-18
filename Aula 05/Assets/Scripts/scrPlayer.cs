using UnityEngine;
using System.Collections;

public class scrPlayer : MonoBehaviour {
    
    #region Propriedades
    public float velocidadePlayer = 0.05f;
    private int direcao = 0;
    public float limite = 2.3f;
    public scrUI ui;
    public scrAudio sons;
    #endregion



    // Use this for initialization
    void Start () {
        sons.motorCarro.Play();
    }

    #region Verifica a direcao que o Player vai movimentar baseado nas teclas
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
    #endregion

   
    // Update is called once per frame
    void Update () {
        VerificaDirecao();

        #region Deslocamento do Player - Horizontal
        float posicaoX = transform.position.x;
        posicaoX += direcao * velocidadePlayer;

        posicaoX = Mathf.Clamp(posicaoX, limite*-1, limite);

        transform.position = new Vector3(posicaoX, transform.position.y, transform.position.z);
        #endregion
    }

    void OnCollisionEnter2D(Collision2D quem)
    {
        sons.motorCarro.Stop();
        sons.batida.Play();
        ui.VerificaSeAcabou();
        Destroy(gameObject);
    }
}
