using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjMoving : MonoBehaviour
{
    public float speed;

    private void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               //Права на данный курс принадлежат Дорофеевой Карине Олеговне, данный курс создавался для Udemy сайта
    }
}
