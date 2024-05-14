using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uiInteraction : MonoBehaviour
{
    [SerializeField] private GameObject[] tiposInfo;

    //Tortuga = 0
    //Estrella de Mar = 1
    //Pescado carpa = 2
    //Tiburon Blanco = 3
    //Tiburon Martillo = 4
    //Ballena Jorobada = 5
    //Aguja Blanca = 6
    //Manta Gigante = 7
    //Calamar Luminoso = 8
    //Cardumen = 9
    //Boga de Rio = 10
    //Caballo de Mar = 11
    //Cocodrilo = 12
    //Manta Raya = 13
    //Orca = 14
    //Tiburon Tigre = 15
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
