using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    
    [SerializeField]
    int Seconds = 60;
    [SerializeField]
    GameObject ChooseEnemyObject;

    IEnumerator Timer()
    {
        while (Seconds > 0)
        {
            Seconds -= 1;
            GetComponent<Text>().text = Seconds.ToString();
            yield return new WaitForSeconds(1);
        }
        ChooseEnemyObject.GetComponent<ChooseEnemyScript>().ShootAll();

    }

    void Start()
    {
        StartCoroutine(Timer());
    }
}
