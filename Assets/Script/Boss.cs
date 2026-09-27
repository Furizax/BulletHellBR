using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private int hp;
    [SerializeField] private float damage;
    [SerializeField] private float moveSpeed;
    [SerializeField] private float fireRate;
    private bool isDead; 

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(int damage)
    {
        hp -=  damage;

        if(hp <= 0)
        {
            Destroy(gameObject);
        }
    }
}
