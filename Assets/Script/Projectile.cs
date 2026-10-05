using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private float projectileSpeed;
    private Vector2 direction;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        rb.velocity = direction * projectileSpeed; //mouvement du projectile
    }

    public void SetDirection(Vector2 newDirection)
    {
        direction = newDirection;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        Boss boss = collision.gameObject.GetComponent<Boss>();
        BossProjectile bossProjectile = collision.gameObject.GetComponent<BossProjectile>();
        if (collision.gameObject.CompareTag("Boss"))
        {
            StatusController statusController = boss.GetComponent<StatusController>();
            statusController.StatusBuildUp(StatusController.Status.Burn, 5f);
            Debug.Log("Burn damage !");
            boss.TakeDamage(0);
            Destroy(gameObject);
        }
        else if (collision.gameObject.CompareTag("Border"))
        {
            Destroy(gameObject);
        }
        else if(collision.gameObject.CompareTag("BossProjectile"))
        {
            Destroy(bossProjectile.gameObject);
            Destroy(gameObject);
        }
    }
}
