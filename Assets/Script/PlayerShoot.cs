using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] private Transform bulletSpawn;
    [SerializeField] private GameObject aim;
    [SerializeField] private GameObject projectilePrefab;

    public void HandleShoot(InputAction.CallbackContext context)
    {
        if(context.performed)
        {
            GameObject bullet = Instantiate(projectilePrefab, bulletSpawn.position, bulletSpawn.rotation);

            Projectile projectile = bullet.GetComponent<Projectile>();
        }
    }

}
