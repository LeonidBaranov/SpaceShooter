using System.Collections;
using System.Collections.Generic;
using UnityEngine;
                                                                                                                                                                                                                                                                                                                                                                                                                                                        //Права на данный курс принадлежат Дорофеевой Карине Олеговне, данный курс создавался для Udemy сайта
public class RepeatingBG : MonoBehaviour
{
    public float vertical_Size; 
    private Vector2 _offSet_Up;

    private void Update()
    {
        if (transform.position.y < -vertical_Size)
        {
            RepeatBackground();
        }
    }
    void RepeatBackground() 
    {
        _offSet_Up = new Vector2(0, vertical_Size * 2f);
        transform.position = (Vector2)transform.position + _offSet_Up;
    }
}