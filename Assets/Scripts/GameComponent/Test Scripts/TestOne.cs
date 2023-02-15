using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestOne : ComponentBase
{
    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.T))
        {
            TriggerNext();
        }

    }
    public override void TriggerNext()
    {
        isTriggered = true;
        nextItem.GetComponent<ComponentBase>().DoAction();

    }

    public override void DoAction()
    {
        CheckPrevious();
        //then does action. this one does not have an action associated with it though
    }

    protected override bool CheckPrevious()
    {
        return previousItem.GetComponent<ComponentBase>().isTriggered;
    }
}
