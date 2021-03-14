using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelDifficultScript : MonoBehaviour
{
    [SerializeField]
    GameObject SelectDifficultWindows;

    [SerializeField]
    float EasyCoof = 10f;

    [SerializeField]
    float MediumCoof = 20f;

    [SerializeField]
    float HardCoof = 30f;

    private float _coof = 0f;

    public void Start()
    {
        Time.timeScale = 0;
    }

    private void ChooseDifficult(float coof)
    {
        _coof = coof;
        SelectDifficultWindows.SetActive(false);
        Time.timeScale = 1;
    }

    public void SetEasy() => ChooseDifficult(EasyCoof);
    public void SetMedium() => ChooseDifficult(MediumCoof);
    public void SetHard() => ChooseDifficult(HardCoof);
    public bool IsWinOrLose(int score) => score < _coof;

}
