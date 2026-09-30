using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossStats : MonoBehaviour
{
    [Header("Stats")]
    public int Hp;
    public int damage;
    public int defense; 
    public float speed;
    public float fireRate;
    public float StatusDurationRes;
    public float statusVulnerability;

    [Header("DOT Resistance")]
    public float BurnRes; //Brule overTime
    public float PoisonRes; //Petit dégât overtime
    public float FrostRes; //Ralenti la cadence de tir du boss 
    public float FreezeRes; // Ralenti la vitesse du boss 
    public float ShockRes; //Micro stagger et dégât overtime
    public float BleedRes; //Massive dégât et petit dégât overtime
    public float HPDrainRes; //Vole la vie du boss pour se saigner soi même

    [Header("Catalyst")]
    public float Oil; //Catalyseur 
    public float Wet; //Catalyseur

    [Header("Control")]
    public float StaggerRes;

    [Header("System")]
    public float StatusDecay; //Vitesse que les buildup redescend
    public float ResistanceGrowth;

}
