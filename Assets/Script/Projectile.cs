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
        rb.velocity = direction * projectileSpeed;  
    }

    public void SetDirection(Vector2 newDirection)
    {
        direction = newDirection;
    }
}
