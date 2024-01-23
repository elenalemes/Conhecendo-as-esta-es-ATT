using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScriptConhecer : MonoBehaviour
{

    public string cena;

    public void Conhecer_verão( ) {
        SceneManager.LoadScene(cena);
    }

    public void Conhecer_outono( ) {
        SceneManager.LoadScene(cena);
    }

    public void Conhecer_inverno( ) {
        SceneManager.LoadScene(cena);
    }

    public void Conhecer_primavera( ) {
        SceneManager.LoadScene(cena);
    }

    public void Conhecer_Parabens( ) {
        SceneManager.LoadScene(cena);
    }
}
