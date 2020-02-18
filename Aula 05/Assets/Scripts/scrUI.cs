using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class scrUI : MonoBehaviour {

    public float qtdPontos;
    public Text textoPontos;
    public Text textoPausa;
    public Button[] botoes;
    bool gameOver;
    public scrAudio som;

    // Use this for initialization
    void Start ()
    {
        gameOver = false;
        qtdPontos = 0;
        InvokeRepeating("AtualizaPontos", 1f, 1f);
    }


    // Update is called once per frame
    void Update () {
        if (!gameOver)
        {
            if (textoPausa)
            {
                textoPausa.text = "| |";
                textoPontos.text = "Tempo: " + qtdPontos + "s";
            }
        }
        else
        {
            textoPausa.text = " < ";
            textoPontos.text = "Fim de Jogo: " + qtdPontos + "s";
        }

    }

    void AtualizaPontos()
    {
        if (!gameOver)
            qtdPontos++;
    }

    public void VerificaSeAcabou()
    {
        gameOver = true;
        foreach (Button botao in botoes)
        {
            botao.gameObject.SetActive(true);
        }
    }

    public void Pausar()
    {
        if (gameOver)
        {
            SceneManager.LoadScene(0);
        }
        else
        {
            if (Time.timeScale == 1)
            {
                som.motorCarro.Stop();
                Time.timeScale = 0;
            }
            else
            {
                if (Time.timeScale == 0)
                {
                    som.motorCarro.Play();
                    Time.timeScale = 1;
                }
            }
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
