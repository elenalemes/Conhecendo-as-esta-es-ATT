using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu_play : MonoBehaviour
{
    public string cena;

    public void QuitGame( ) 
        {
            // Enquanto no Editor Unity
            UnityEditor.EditorApplication.isPlaying = false;
            // Quando o jogo ja compilado
            //Application.Quit();
        }

    public void Carrega_infos( ) {
        SceneManager.LoadScene(cena);
    }

    public void Play_Game( ) {
        SceneManager.LoadScene(cena);
    }
}
