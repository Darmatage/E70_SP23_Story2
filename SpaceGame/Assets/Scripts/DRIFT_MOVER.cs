using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DRIFT_MOVER : MonoBehaviour
{
	// Time taken to go from start to target scale
      public float ShrinkDuration = 5f;
	  
	  //speed of movement
	  public float speed = 2;
	  public float sidespeed = 6;
	  
     
      // target scale
      public Vector3 TargetScale = Vector3.one * .5f;
     
      //  starting scale
      Vector3 startScale;
     
      //interpolant for our linear interpolation.
      float t = 0;
    // Start is called before the first frame update
    void Start()
    {
		 // initialize 
        startScale = transform.localScale;
        t = 0;
    }

    // Update is called once per frame
    void Update()
    {	
			 // Divide deltaTime by the duration to stretch out the time it takes for t to go from 0 to 1.
        t += Time.deltaTime / ShrinkDuration;
		
		
		// Moves the object down and right at speed units per second.
		transform.Translate(Vector3.down * speed * Time.deltaTime);
		transform.Translate(Vector3.right * sidespeed * Time.deltaTime);
     
        // Lerp wants the third parameter to go from 0 to 1 over time. 't' will do that for us.
        Vector3 newScale = Vector3.Lerp(startScale, TargetScale, t);
        transform.localScale = newScale;
     
        // finished, can be disabled
        if (t > 1) {
          enabled = false;
        }
    }
}