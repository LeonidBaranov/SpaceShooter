﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetsAndBonus : MonoBehaviour
{
    public GameObject[] obj_Planets;
    public float time_Planet_Spawn;
    public float speed_Planets;
    List<GameObject> planetsList = new List<GameObject>();

    private void Start()
    {
        StartCoroutine(PlanetsCreation());
    }

    IEnumerator PlanetsCreation()
    {
        for (int i = 0; i < obj_Planets.Length; i++)
        {
            planetsList.Add(obj_Planets[i]);
        }
        yield return new WaitForSeconds(7);
        while (true)
        {
            int randomIndex = Random.Range(0, planetsList.Count);
            GameObject newPlanet = Instantiate(planetsList[randomIndex],
                new Vector2(Random.Range(PlayerMoving.instance.borders.minX, PlayerMoving.instance.borders.maxX),
                PlayerMoving.instance.borders.maxY * 1.7f),
                Quaternion.Euler(0, 0, Random.Range(-25, 25)));

            planetsList.RemoveAt(randomIndex);
            if (planetsList.Count == 0)
            {
                for (int i = 0; i < obj_Planets.Length; i++)
                {
                    planetsList.Add(obj_Planets[i]);
                }
            }
            newPlanet.GetComponent<ObjMoving>().speed = speed_Planets;
            yield return new WaitForSeconds(time_Planet_Spawn);
        }
    }
}