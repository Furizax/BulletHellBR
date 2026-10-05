using System.Collections;
using System.Collections.Generic;
using Unity.PlasticSCM.Editor.WebApi;
using Unity.VisualScripting;
using UnityEngine;

public class Boss : MonoBehaviour
{
    private Rigidbody2D rb;
    public GameObject player;
    private BossStats stats;
    [SerializeField] private Transform[] shootPoints;
    [SerializeField] private GameObject projectilePrefab;
    [SerializeField] private int currentHP;
    [SerializeField] private float fireRate = 0.5f;
    private float shootTime = 0.1f;
   // [SerializeField] private float damage;
    private bool isDead;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        stats = GetComponent<BossStats>();
        player = GameObject.FindGameObjectWithTag("Player");
        currentHP = stats.Hp;
    }

    // Update is called once per frame
    void Update()
    {
        shootTime += Time.deltaTime;
        if(shootTime >= fireRate)
        {
            ShootPoint();
            shootTime = 0;
        }

    }

    public void ShootPoint()
    {
        foreach(Transform point in shootPoints)
        {
            if(point != null)
            {
                GameObject projectile = Instantiate(projectilePrefab, point.position, point.rotation);
                BossProjectile bossProjectile = projectile.GetComponent<BossProjectile>();

                Vector2 direction = point.right;
                direction = direction.normalized;
                bossProjectile.SetDirection(direction);
            }
        }
    }

    public void TakeDamage(int damage)
    {
        currentHP -= damage;
        if (currentHP <= 0)
        {
            Destroy(gameObject);
            isDead = true;
        }
    }
}
