using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] private Transform projectileSpawn;
    [SerializeField] private Transform aim;
    [SerializeField] private GameObject projectilePrefab;

    public void HandleShoot(InputAction.CallbackContext context)
    {
        if(context.performed)
        {
            GameObject bullet = Instantiate(projectilePrefab, projectileSpawn.position, projectileSpawn.rotation);

            Projectile projectile = bullet.GetComponent<Projectile>();

            Vector2 direction = new Vector2(
                aim.position.x - projectileSpawn.position.x,
                aim.position.y - projectileSpawn.position.y
                );
            direction = direction.normalized;

            projectile.SetDirection(direction);
        }
    }
}
