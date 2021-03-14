using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseEnemyScript : MonoBehaviour
{
    [SerializeField]
    GameObject[] Enemies;
    [SerializeField]
    float Seconds = 1;

    private GameObject _CurrentEnemy;
    private bool isGameContinue = true;

    private IEnumerator ChooseEnemy_Timer()
    {
        while (isGameContinue)
        {
            int index = Random.Range(0, Enemies.Length - 1);
            if (_CurrentEnemy != null)
            {
                _CurrentEnemy.GetComponent<EnemyScript>().IsCurrent = false;
            }
            _CurrentEnemy = Enemies[index];
            _CurrentEnemy.GetComponent<EnemyScript>().IsCurrent = true;
            yield return new WaitForSeconds(Seconds);
        }
    }

    public void ShootAll()
    {
        foreach (var item in Enemies)
        {
            item.GetComponent<EnemyScript>().ShootHero();
        }
        isGameContinue = false;
    }

    void Start()
    {
        StartCoroutine(ChooseEnemy_Timer());
    }
}
