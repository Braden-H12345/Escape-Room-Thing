using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    
    private bool openDoor = false;
    private float smooth = .01f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.G))
        {
            openDoor = true;
        }
        if(openDoor &&  (transform.rotation.y >= -80f))
        {
            Quaternion desiredRoatation = Quaternion.Euler(0, -80, 0);
            transform.rotation = Quaternion.Lerp(transform.rotation, desiredRoatation, smooth);
        }
        
    }
}
