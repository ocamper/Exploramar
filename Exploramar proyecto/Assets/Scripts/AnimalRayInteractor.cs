using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalRayInteractor : MonoBehaviour
{
    public SkinnedMeshRenderer m_Renderer;
    [SerializeField] private Material[] materials;
    [SerializeField] private GameObject _canvas;
    [SerializeField] private float billboardVerticalDistance;
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
