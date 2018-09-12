public class Person : MonoBehaviour
{
    public string personName = "Glenn Glennson";

    public virtual void PrintInfo()
    {
        Debug.Log(personName);
    }

}
repetition
using System.Collections;
using System.Collections.Generic;
using UnityEngine;