using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour, ISubject
{
    private static GameManager instance;
    private float progress;
    private float timer;
    private void Update()
    {
        timer += Time.deltaTime;
        if(timer >= progress)
        {
            Notify();
        }
    }
    public void Notify()
    {

    }
    public static GameManager GetInstance()
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
