using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PlaySceneManager : MonoBehaviour
{
    public InputActionReference menuReturn;
    public GameObject fadeScreen;
    private Animator fadeController;

    private void Awake()
    {
        menuReturn.action.Enable();
        menuReturn.action.performed += ReturnToMenu;
        fadeController = fadeScreen.GetComponent<Animator>();
    }

    private void ReturnToMenu(InputAction.CallbackContext context)
    {
        fadeController.SetBool("fadeIn", true);
    }

    public void ActivateChangeToMenu()
    {
        SceneManager.LoadSceneAsync(0);
    }
}
