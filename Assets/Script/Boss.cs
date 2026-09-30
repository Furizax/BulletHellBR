using System.Collections;
using System.Collections.Generic;
using Unity.PlasticSCM.Editor.WebApi;
using UnityEngine;

public class Boss : MonoBehaviour
{
    private Rigidbody2D rb;
    private BossStats stats;
    [SerializeField] private int currentHP;
   // [SerializeField] private float damage;
    //[SerializeField] private float moveSpeed;
   // [SerializeField] private float fireRate;
    private bool isDead; 

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        stats = GetComponent<BossStats>();
        currentHP = stats.Hp;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(int damage)
    {
        currentHP -=  damage;

        if(currentHP <= 0)
        {
            Destroy(gameObject);
            isDead = true;
        }
    }
}
