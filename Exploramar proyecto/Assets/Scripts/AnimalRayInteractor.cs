using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalRayInteractor : MonoBehaviour
{
    public SkinnedMeshRenderer m_Renderer;
    [SerializeField] private Material[] materials;

    public void ActivarInteraccion() => m_Renderer.material = materials[1];

    public void DesactivarInteraccion() => m_Renderer.material = materials[0];

    public void AnimalElegido() => Debug.Log("interaccion con " + gameObject);
}
