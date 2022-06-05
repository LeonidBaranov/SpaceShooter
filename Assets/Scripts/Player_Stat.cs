using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Stat : MonoBehaviour
{
    [SerializeField] private int player_health;

    [SerializeField] public static Player_Stat point = null;

    public void Awake()
    {
        if ( point == null)
        {
            point = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void GetDamage(int Damage)
    {
        player_health -= Damage;

        if (player_health <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.tag == "Bullet_enemy")
        {
            GetDamage(1);
            Destroy(coll.gameObject);
        }
    }
}
