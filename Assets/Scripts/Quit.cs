using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit : MonoBehaviour
{
    public void QuitButton ()
    {
        Debug.Log("Quit command executed");
        Application.Quit();
    }
}
