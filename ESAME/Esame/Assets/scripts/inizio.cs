using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class inizio : MonoBehaviour
{
    public GameObject menuCanvas;
    public FirstPersonController fpsController;
    public void inizia_scena_giorno(){
        SceneManager.LoadSceneAsync("Scenes/giorno/giorno_buio");
    }

    public void inizia_scena_notte(){
        SceneManager.LoadSceneAsync("Scenes/notte/notte_buio");
    }

    public void indietro(){
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        fpsController.enabled = true;
        menuCanvas.SetActive(false);
    }

    public void quit(){
        Application.Quit();
    }

}
