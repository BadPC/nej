student
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Student : Person
{
    public string klass;

    public override void PrintInfo()
    {
        base.PrintInfo();
        Debug.Log(klass);
    }
}
teacher
using System.Collections;
using System.Collections.Generic;
using UnityEngine;