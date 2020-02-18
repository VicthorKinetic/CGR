using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class scr_UI : MonoBehaviour {

    public scr_Balde balde;
    public scr_ContarGotas ConGot;
    public Text txtGotasBalde;
    public Text txtGotasTotal;
    public Text txtGotasPerdidas;
    public Text txtFim;
    public Button[] botoes;
    public bool gameOver;

    // Use this for initialization
    void Start () {
        gameOver = false;
    }

    // Update is called once per frame
    void Update() {

        if (!gameOver)
        {
            txtGotasBalde.text = "Gotas no Balde: " + balde.gotasobtidas.ToString();
            txtGotasTotal.text = "Gotas no Total: " + balde.gotastotal.ToString();
            txtGotasPerdidas.text = "Gotas Perdidas: " + ConGot.chances.ToString();
        }
        else
        {
            txtFim.text = "Fim de Jogo: " + balde.gotastotal.ToString() + " Gotas Obtidas";
        }
    }

    public void VerificaSeAcabou()
    {
            gameOver = true;
            foreach (Button botao in botoes)
            {
                botao.gameObject.SetActive(true);
            }

    }

    public void Recomecar()
    {
        SceneManager.LoadScene(1);
    }

    public void Sair()
    {
        Application.Quit();
    }

    public void Iniciar()
    {
        SceneManager.LoadScene(1);
    }

    public void Menu()
    {
        SceneManager.LoadScene(0);
    }
}
