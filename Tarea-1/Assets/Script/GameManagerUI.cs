using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerUI : MonoBehaviour, iSubject
{
    private static GameManagerUI instance;

    public static GameManagerUI GetInstance()
    {
        return instance;
    }

    public void Attach(iObserver observer)
    {
    }

    public void Remove(iObserver observer)
    {
    }
}
