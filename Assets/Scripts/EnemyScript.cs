using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{


    const string PlayerTag = "Player";

    [SerializeField]
    GameObject Marker;

    private GameObject _player;
    private GameObject _activeMarker;

    private bool _isCurrent;
    public bool IsCurrent { 
        get { return _isCurrent; }
        set {
            if(value == true)
            {
                createMarker(transform.position.x);
            }
            else
            {
                Destroy(_activeMarker);
                _player.GetComponent<HeroController>().CheckHitAndScore(transform.position.x);
            }
            _isCurrent = value; 
        }
    }

    public void createMarker(float x)
    {
        if (_activeMarker != null)
            Destroy(_activeMarker);

        _activeMarker = Instantiate(Marker);
        _activeMarker.transform.position = new Vector3
                (
                    x,
                    Marker.transform.position.y,
                    Marker.transform.position.z
                );
    }

    private void Start()
    {
        _player = GameObject.FindGameObjectWithTag(PlayerTag);
    }

    void Update()
    {
        
    }

    public void ShootHero()
    {
        _player.GetComponent<ControllerScript>().Block();
        _player.GetComponent<HeroController>().EndPhase = true;
        createMarker(_player.transform.position.x);
        IsCurrent = false;
    }

}
