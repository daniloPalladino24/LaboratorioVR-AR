using UnityEngine;
using UnityEngine.UI;

public class InGameMenuController : MonoBehaviour
{
    public GameObject menuCanvas;
    public FirstPersonController fpsController;

    void Start()
    {

        menuCanvas.SetActive(false);

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {

            menuCanvas.SetActive(!menuCanvas.activeSelf);

   
            if (menuCanvas.activeSelf)
            {
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                fpsController.enabled = false;
            }
            else
            {
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
                fpsController.enabled = true;
            }
        }
    }
}