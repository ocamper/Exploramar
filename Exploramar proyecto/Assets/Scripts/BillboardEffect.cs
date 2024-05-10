using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BillboardEffect : MonoBehaviour
{
    Vector3 cameraDir;

    // Update is called once per frame
    void Update()
    {
        cameraDir = Camera.main.transform.forward;

        transform.rotation = Quaternion.LookRotation(cameraDir);
    }
}
