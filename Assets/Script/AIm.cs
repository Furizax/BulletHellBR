using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AIm : MonoBehaviour
{

    [SerializeField] private Camera mainCamera;
    [SerializeField] private Transform player;
    private Vector2 directionLooking;
    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0f;
        transform.position = mousePos;

        directionLooking = transform.position - player.position;


        float angle = Mathf.Atan2(directionLooking.y, directionLooking.x) * Mathf.Rad2Deg;
        angle -= 90;

        player.rotation = Quaternion.Euler(0, 0, angle);

    }
}
