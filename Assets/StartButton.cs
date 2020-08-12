using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButton: MonoBehaviour
{

    public bool CanStartGame = false;

    public void OnStartButtonClick()
    {
        UseStartButton();
    }

    public void UseStartButton()
    {
        CanStartGame = true;
    }



}
