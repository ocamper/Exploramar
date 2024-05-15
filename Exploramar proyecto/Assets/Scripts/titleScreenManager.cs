using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class titleScreenManager : MonoBehaviour
{

    [SerializeField] private GameObject fadeScreen;
    [SerializeField] private GameObject[] colliders;
    private Animator fadeController;
    private int changeID;
    

    private void Awake()
    {
        fadeController = fadeScreen.GetComponent<Animator>();
    }

    public void ButtonSelected(int selected)
    {
        Debug.Log(selected + " was selected");
        fadeController.SetBool("fadeIn", true);
        changeID = selected;
        foreach (GameObject obj in colliders)
        {
            obj.SetActive(false);
        }
    }

    public void SceneChange()
    {
        SceneManager.LoadSceneAsync(changeID);
    }

}
