using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour, ISubject
{
    private static GameManager instance;
    private float progress;
    private List<iObserver> Enemy = new List<iObserver>();
    private float timer;
    public float Progession { get{return progress;}}
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
        foreach (iObserver observer in Enemy)
        {
            observer.Execute(this);
        }
    }
    public static GameManager GetInstance()
    {
        return instance;
    }

    public void Attach(iObserver observer)
    {
        Enemy.Add(observer);
    }

    public void Remove(iObserver observer)
    {
        Enemy.Remove(observer);
    }
}
