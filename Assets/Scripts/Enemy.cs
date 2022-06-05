using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private int enemy_health;

    public void GetDamage(int Damage)
    {
        enemy_health -= Damage;

        if (enemy_health <= 0)
        {
            Destruction();
        }
    }

    public void Destruction()
    {
        Destroy(gameObject);
    }

    public void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.tag == "Player")
        {
            GetDamage(1);
            Player_Stat.point.GetDamage(1);
        }
        if (coll.tag == "Bullet")
        {
            GetDamage(1);
            Destroy(coll.gameObject);
        }
    }
}
