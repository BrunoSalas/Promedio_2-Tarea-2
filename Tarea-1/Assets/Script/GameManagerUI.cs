using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerUI : MonoBehaviour
{
    private static GameManagerUI instance;

    public static GameManagerUI GetInstance()
    {
        return instance;
    }
}
