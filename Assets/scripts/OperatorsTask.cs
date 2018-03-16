using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OperatorsTask : MonoBehaviour
{
    public int a;
    public int b;
    public int c;
    string characterName = "Uther";
    string gameClass;

    // Use this for initialization
    void Start ()
    {
        MyFunction ();
        MyFunction2 ();
    }

    // Update is called once per frame
    void Update ()
    {

    }

    void MyFunction ()
    {
        if ((a + c) > b)
        {
            print ("failed");
        } else
            print ("succes");
    }
    void MyFunction2 ()
    {
        if (a == b && c < 0)
        {
            string gameClass = "Death Knight";
            print(characterName + " " + gameClass);

        }
        else if (a != b && a < 0)
        {
            string gameClass = "Druid";
            print(characterName + " " + gameClass);

        }
        else if (a == 2 * b || c > 0)
        {
            string gameClass = "Paladin";
            print(characterName + " " + gameClass);

        }
        else
            print("caracter not found");
    }
}