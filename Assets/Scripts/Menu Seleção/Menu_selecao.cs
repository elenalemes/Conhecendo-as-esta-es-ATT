using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class Menu_selecao : MonoBehaviour
{

public string cena;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Start_Conhecer ( ) {
        SceneManager.LoadScene(cena);
    }

    public void Start_Ligar ( ) {
        SceneManager.LoadScene(cena);
    }

    public void Start_Associar ( ) {
        SceneManager.LoadScene(cena);
    }
}
