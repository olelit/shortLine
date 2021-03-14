using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroController : MonoBehaviour
{    
    public int Score = 0;
    public bool EndPhase = false;

    [SerializeField]
    GameObject WinOrLoseWindow;


    // Update is called once per frame
    void Update()
    {
        
    }
    public void FinalShoot()
    {
        if (IsDead())
        {
            GetComponent<Rigidbody>().AddForce(Vector3.forward*1, ForceMode.Impulse);
            WinOrLoseWindow.SetActive(true);
            Time.timeScale = 0;
            SaveLoadScore.SaveIfBiggestThenCurrent(Score);
        }
    }

    private bool IsDead()
    {
        return Camera.main.GetComponent<LevelDifficultScript>().IsWinOrLose(Score);
    }

    public void CheckHitAndScore(float x)
    {
        if(transform.position.x == x)
        {
            Score += 1;
        }
        if (EndPhase)
        {
            FinalShoot();
        }
    }
}
