using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keypad : MonoBehaviour
{
    [SerializeField] int correctCode;

    private List<int> currentlyEntered = new List<int>();

    private bool checkedAlready = false;
    private void Update()
    {
        if (currentlyEntered != null)
        {
            if (currentlyEntered.Count == 4 && !checkedAlready)
            {
                checkedAlready = true;
                CheckCorrect();
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            if(currentlyEntered.Count < 4)
            {
                currentlyEntered.Add(0);
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            if (currentlyEntered.Count < 4)
            {
                currentlyEntered.Add(1);
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            if (currentlyEntered.Count < 4)
            {
                currentlyEntered.Add(2);
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            if (currentlyEntered.Count < 4)
            {
                currentlyEntered.Add(3);
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            if (currentlyEntered.Count < 4)
            {
                currentlyEntered.Add(4);
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            if (currentlyEntered.Count < 4)
            {
                currentlyEntered.Add(5);
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            if (currentlyEntered.Count < 4)
            {
                currentlyEntered.Add(6);
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            if (currentlyEntered.Count < 4)
            {
                currentlyEntered.Add(7);
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            if (currentlyEntered.Count < 4)
            {
                currentlyEntered.Add(8);
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha9))
        {
            if (currentlyEntered.Count < 4)
            {
                currentlyEntered.Add(9);
            }
        }
    }

    private void CheckCorrect()
    {
        int checkNum = (currentlyEntered[0] * 1000) + (currentlyEntered[1] * 100) + (currentlyEntered[2] * 10) + currentlyEntered[3];

        if(checkNum == correctCode)
        {
            Debug.Log("Code Correct! Woohoo!");
        }
        else
        {
            Debug.Log("Wrong code!");
        }
    }

}
