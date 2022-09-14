using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Colisao : MonoBehaviour
{

    public string Cena;

    void OnTriggerEnter(Collider fase) {
        if (fase.gameObject.tag == "Player") {
            MudarCena();
        }
    }
    public void MudarCena()
    {
        SceneManager.LoadScene(Cena);
    }
    public void Sair(){
        Application.Quit();
    }
}
