using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="EnemyInfo",menuName ="Enemy")]
public class EnemyInfo : ScriptableObject
{
    public string EnemyName;
    public int Health;
    public int MaxHealth;
    public int[] Attacks;
    public Sprite Sprite;
}
