using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
   bool open= false;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space")){
            if(open)
                this.transform.Translate(0,-3,0);
            else
                this.transform.Translate(0,3,0);
            open = !open;
        }
    }
}
