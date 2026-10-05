using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class StatusController : MonoBehaviour
{
    private Boss boss;
    private BossStats bossStats;
    private float currentBuildUp;
    private int effectBuildDamage;
    private float effectBuildDuration;
    private bool isBurning;

    public enum Status
    {
        Burn
    }

    // Start is called before the first frame update
    void Start()
    {
        bossStats = GetComponent<BossStats>();
        boss = GetComponent<Boss>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StatusBuildUp(Status statusType, float buildupValue)
    {
        //Debug.Log("StatusBuildUp appelé : " + statusType);
        if (statusType == Status.Burn && isBurning)
            return; 

        switch (statusType)
        {
            case Status.Burn:
                currentBuildUp += buildupValue;
                if (currentBuildUp >= bossStats.BurnRes)
                {
                    isBurning = true;
                    Debug.Log("Boss is burning");
                    StartCoroutine(Burn(10f));
                }
                break;

        }
    }

    private IEnumerator Burn(float duration)
    {
        float elapsed = 0f;
        float damageTimer = 0f;
        while (elapsed < duration)
        {
            damageTimer += Time.deltaTime;
            if (damageTimer >= 2)
            {
                boss.TakeDamage(7);
                damageTimer = 0f;
            }
            elapsed += Time.deltaTime;
            yield return null;
        }

        isBurning = false;
        bossStats.BurnRes += bossStats.ResistanceGrowth;
        currentBuildUp = 0;
       
    }
}
