using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartSeamouve : MonoBehaviour
{
    
    public GameObject Sea;
    public int GameSpeed;
    public bool CanStartGame;


    private void Start()
    {
        CanStartGame = GetComponent<StartButton>().CanStartGame;
    }

    void Update()
    {
        if (CanStartGame == true)
        {
            this.transform.Translate(Vector3.back * GameSpeed);
        }
    }

}
