using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceObj : MonoBehaviour
{
    public Transform ObjToFace = null;
    public bool FacePlayer = false;

    private void Awake()
    {
        if (!FacePlayer) { return; }
        GameObject PlayerObj = GameObject.FindGameObjectWithTag("Player");

        if (PlayerObj != null)
        {
            ObjToFace = PlayerObj.transform;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (ObjToFace == null) { return; }

        Vector3 DirToObj = ObjToFace.position - transform.position;

        if(DirToObj != Vector3.zero)
        {
            transform.localRotation = Quaternion.LookRotation(DirToObj.normalized, Vector3.up);
        }

    }
}
