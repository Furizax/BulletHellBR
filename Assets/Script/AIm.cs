using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIm : MonoBehaviour
{

    [SerializeField] private Camera mainCamera;
    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;
        transform.position = mousePos;  
    }
}
