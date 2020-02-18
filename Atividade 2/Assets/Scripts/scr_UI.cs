using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class scr_UI : MonoBehaviour {

    public scr_Perder perder;
	public scr_Pacman pac;
    public Text txtChances;
	public Text txtPerdeu;
	public Text txtGanhou;
	public Button reiniciar;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		txtChances.text = "Chances: " + perder.chances.ToString ();

		if (pac.FantasmasAcertos >= 28) {
			pac.bola.gameObject.SetActive (false);
			txtChances.gameObject.SetActive (false);
			txtGanhou.gameObject.SetActive (true);
			reiniciar.gameObject.SetActive (true);
		}

		if (perder.chances == 0) {
			txtPerdeu.gameObject.SetActive (true);
			txtChances.gameObject.SetActive (false);
			reiniciar.gameObject.SetActive (true);
		}

	}
    public void Iniciar()
	{
    	SceneManager.LoadScene("Jogo");
	}
}
