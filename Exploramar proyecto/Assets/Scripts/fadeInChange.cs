using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class fadeInChange : MonoBehaviour
{
    [SerializeField] private GameObject screenManager;
    private titleScreenManager titleScreenManager;
    private PlaySceneManager playSceneManager;

    private void Awake()
    {
        titleScreenManager = screenManager.GetComponent<titleScreenManager>();
        playSceneManager = screenManager.GetComponent<PlaySceneManager>();
    }

    public void SceneChange()
    {
        if (titleScreenManager != null)
            titleScreenManager.SceneChange();
        else
            playSceneManager.ActivateChangeToMenu();
    }
}
