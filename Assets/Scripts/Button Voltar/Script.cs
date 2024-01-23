using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    public string cena;

     public void Voltar_aoMenu( ) {
        SceneManager.LoadScene(cena);
    }

    public void Voltar_Estacoes( ) {
        SceneManager.LoadScene(cena);
    }
}
