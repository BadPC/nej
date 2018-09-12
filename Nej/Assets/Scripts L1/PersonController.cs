public class PersonController : MonoBehaviour
{
    public Person person;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            person.PrintInfo();
        }
    }
}
person
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
