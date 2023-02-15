using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestTwo : ComponentBase
{
    public override void TriggerNext()
    {

        nextItem.GetComponent<ComponentBase>().DoAction();

    }

    public override void DoAction()
    {
        CheckPrevious();

        //this code will be different for every component. in this case i simply want to open the door that this is attached to
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 30; j++)
            {
                Quaternion desiredRoatation = Quaternion.Euler(0, -80, 0);
                this.gameObject.transform.rotation = Quaternion.Lerp(transform.rotation, desiredRoatation, .01f);
            }
        }
        
        
    }

    protected override bool CheckPrevious()
    {
        return previousItem.GetComponent<ComponentBase>().isTriggered;
    }
}
