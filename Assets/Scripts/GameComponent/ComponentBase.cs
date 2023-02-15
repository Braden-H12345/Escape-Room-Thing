using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ComponentBase : MonoBehaviour
{
    //this functions as the base class for all game components in an escape room that trigger an action

    //for example a keypad that opens a secret compartment, a button that opens a door, or any action that causes a reaction

    //this is the item that will previously affect these objects. essentially what needs to be done before accessing them. some items do not require them!
    [Header("Previous Item")]
    [SerializeField] protected GameObject previousItem;

    //this is what this component affects. essentially the action after the task is finished
    [Header("Next Item")]
    [SerializeField] protected GameObject nextItem;

    public bool isTriggered = false; // change to true once action is completed

    //finally it needs 2 methods.
    //this method controls the triggering of the next item and is required by all classes of this type
    public abstract void TriggerNext();

    public abstract void DoAction();

    //this method may be used by everything, so it is not required but it controls determining if a previous action was done or not
    protected virtual bool CheckPrevious()
    {
        if (previousItem.GetComponent<ComponentBase>() != null)
        {
            return previousItem.GetComponent<ComponentBase>().isTriggered;
        }
        else
        {
            //why did i attach to this object a component that does not utilize this script LOL
            return false;
        }
    }
}
