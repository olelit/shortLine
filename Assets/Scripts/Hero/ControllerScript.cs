using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerScript : MonoBehaviour
{
    [SerializeField]
    float Shift = 2;
    [SerializeField]
    int Border = 2;

    private int _currentPosition = 0;
    private bool _isBlocked = false;
    // Update is called once per frame
    void Update()
    {
        if (!_isBlocked && Time.timeScale != 0)
        {
            if (Input.GetKeyDown(KeyCode.A) && Mathf.Abs(_currentPosition - 1) <= Border)
            {
                transform.position += Vector3.left * Shift;
                _currentPosition -= 1;
            }


            if (Input.GetKeyDown(KeyCode.D) && Mathf.Abs(_currentPosition + 1) <= Border)
            {
                transform.position += Vector3.right * Shift;
                _currentPosition += 1;
            }
        }
    }

    public void Block()
    {
        if (!_isBlocked)
            _isBlocked = false;
    }
}
