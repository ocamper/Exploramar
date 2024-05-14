using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalRayInteractor : MonoBehaviour
{
    public SkinnedMeshRenderer m_Renderer;
    [SerializeField] private Material[] materials;
    [SerializeField] private GameObject _canvas;
    [SerializeField] private float billboardVerticalDistance;

    [Tooltip("Tortuga = 0\n" +
        "Estrella de Mar = 1\n" +
        "Pescado carpa = 2\n" +
        "Tiburon Blanco = 3\n" +
        "Tiburon Martillo = 4\n" +
        "Ballena Jorobada = 5\n" +
        "Aguja Blanca = 6\n" +
        "Manta Gigante = 7\n" +
        "Calamar Luminoso = 8\n" +
        "Cardumen = 9\n" +
        "Boga de Rio = 10\n" +
        "Caballo de Mar = 11\n" +
        "Cocodrilo = 12\n" +
        "Manta Raya = 13\n" +
        "Tiburon Martillo = 14\n" +
        "Orca = 15\n" +
        "Tiburon Tigre = 16")]
    [SerializeField] private int currentObjType;

    public void ActivarInteraccion() => m_Renderer.material = materials[1];

    public void DesactivarInteraccion() => m_Renderer.material = materials[0];

    public void AnimalElegido()
    {
        Debug.Log("interaccion con " + gameObject);

        if (_canvas != null)
        {
            GameObject otherCanvas = GameObject.FindGameObjectWithTag("AnimalInfo");
            if (otherCanvas != null)
            {
                Destroy(otherCanvas);
            }
            GameObject newInfoBoard = Instantiate(_canvas, new Vector3 (transform.position.x, transform.position.y+billboardVerticalDistance, transform.position.z), transform.rotation);

            newInfoBoard.GetComponent<uiInteraction>().generateInfo(currentObjType);
        }
    }
}
