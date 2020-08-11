using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartSeamouve : MonoBehaviour
{
    
    public GameObject Sea;
    public int GameSpeed;

    void Update()
    {
        this.transform.Translate(Vector3.back * GameSpeed);
    }

}
