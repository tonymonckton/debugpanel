using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TM.Utils;

public class demoScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        debugLog.instance.Log("Input", "Delta Time", Time.deltaTime);
        debugLog.instance.Log("System", "Time", Time.time);
        debugLog.instance.Log("Input", "hello", "hello");
        debugLog.instance.Log("Objects", "sphere", this.transform.position);

/*
        CategoryLog myCat = new CategoryLog();
        myCat.category = "test1";
        debugLog.instance.addCategory( myCat );

        CategoryLog cat = debugLog.instance.getCategory( "test1" );

        if ( cat != null ) {
            cat.expanded = true;
            debugLog.instance.setCategory(cat);
        }
*/    
    }
}
