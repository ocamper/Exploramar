using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uiInteraction : MonoBehaviour
{
    [SerializeField] private GameObject[] tiposInfo;

    //Tortuga = 0
    //Estrella de Mar = 1
    //Pescado carpa = 2
    //Tiburon = 3
    public void generateInfo(int currentAnimal)
    {

        for (int i = 0; i < tiposInfo.Length; i++)
        {
            if (i == currentAnimal)
            {
                tiposInfo[i].SetActive(true);
            }
            else
            {
                tiposInfo[i].SetActive(false);
            }
        }
    }

    public void RemoveBillboard()
    {
        Destroy(gameObject);
    }
}
