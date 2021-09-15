using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/****
 * Created by: Dakota Mitchell
 * Date: Sept 15,2021
 * 
 * Last Edited by:
 * Last updated: Sept 15,2021
 * 
 * Controls Boundary of the game
 */


public class BoundsLock : MonoBehaviour
{

    public Rect levelBounds;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {

        transform.position = new Vector3(Mathf.Clamp(transform.position.x, levelBounds.xMin, levelBounds.xMax), 
            transform.position.y, Mathf.Clamp(transform.position.z, levelBounds.yMin, levelBounds.yMax));
    
    }

    private void OnDrawGizmosSelected()
    {
        const int cubeDepth = 1;

        Vector3 boundsCenter = new Vector3(levelBounds.xMin + levelBounds.width * 0.5f, 0, levelBounds.yMin + levelBounds.height * 0.5f);
        Vector3 boundsHeight = new Vector3(levelBounds.width, cubeDepth, levelBounds.height);

        Gizmos.DrawWireCube(boundsCenter, boundsHeight);
            
    }
}
