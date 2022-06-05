using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_shoot : MonoBehaviour
{

    [SerializeField] float shot_delay = 0.5f;
    private float timer = 0f;

    [SerializeField] Transform shoot_point;
    [SerializeField] private GameObject bullet_pref;

    void Shoot()
    {
        var bullet = Instantiate(bullet_pref, shoot_point.position, Quaternion.identity);
    }

    private void Update()
    {
        timer += Time.deltaTime;

        if (timer > shot_delay)
        {
            Shoot();
            timer = 0f;
        }
    }
}
