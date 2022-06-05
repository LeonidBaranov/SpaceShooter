using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoving : MonoBehaviour
{
    [SerializeField] private GameObject[] obj_Enemy;
    [SerializeField] private float time_Enemy_Spawn;
    [SerializeField] private float speed_Enemy;
    List<GameObject> EnemyList = new List<GameObject>();

    private void Start()
    {
        StartCoroutine(EnemyCreation());
    }

    IEnumerator EnemyCreation()
    {
        for (int i = 0; i < obj_Enemy.Length; i++)
        {
            EnemyList.Add(obj_Enemy[i]);
        }
        yield return new WaitForSeconds(4);
        while (true)
        {
            int randomIndex = Random.Range(0, EnemyList.Count);
            GameObject newEnemy = Instantiate(EnemyList[randomIndex],
                new Vector2(Random.Range(PlayerMoving.instance.borders.minX, PlayerMoving.instance.borders.maxX),
                PlayerMoving.instance.borders.maxY * 1.7f),
                Quaternion.Euler(0, 0, Random.Range(-10, 10)));

            EnemyList.RemoveAt(randomIndex);
            if (EnemyList.Count == 0)
            {
                for (int i = 0; i < obj_Enemy.Length; i++)
                {
                    EnemyList.Add(obj_Enemy[i]);
                }
            }
            newEnemy.GetComponent<ObjMoving>().speed = speed_Enemy;
            yield return new WaitForSeconds(time_Enemy_Spawn);
        }
    }
}