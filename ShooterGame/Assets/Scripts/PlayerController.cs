/****
 * Created by: Dakota Mitchell
 * Date: Sept 13,2021
 * 
 * Last Edited by:
 * Last updated: Sept 15,2021
 * 
 * Controls Player Movement
 */





using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    /*VARIABLES*/
    public bool MouseLook = true; //Looking at mouse
    public string HorzAxis = "Horizontal"; // Horizontal axis movement
    public string VertAxis = "Vertical"; // Vertical axis movement
    public string FireAxis = "Fire1"; // shooty shoot
    public float MaxSpeed = 5f; // movement speed
    private Rigidbody ThisBody = null; // variable for the ship's rigidbody

    //Awake is called before start
    private void Awake()
    {
        ThisBody = GetComponent<Rigidbody>(); //sets the objects rigid body to variable
    }//End awake

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float Horz = Input.GetAxis(HorzAxis);
        float Vert = Input.GetAxis(VertAxis);

        Vector3 MoveDirection = new Vector3(Horz, 0.0f, Vert);
        ThisBody.AddForce(MoveDirection.normalized * MaxSpeed);

        ThisBody.velocity = new Vector3(Mathf.Clamp(ThisBody.velocity.x, -MaxSpeed, MaxSpeed), Mathf.Clamp(ThisBody.velocity.y, -MaxSpeed, MaxSpeed), Mathf.Clamp(ThisBody.velocity.z, -MaxSpeed, MaxSpeed));

        //Look at Mouse
        if (MouseLook) 
        {
            Vector3 MousePosWorld = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0.0f));

            MousePosWorld = new Vector3(MousePosWorld.x, 0, MousePosWorld.z);

            Vector3 LookDirection = MousePosWorld - transform.position;
            transform.localRotation = Quaternion.LookRotation(LookDirection.normalized, Vector3.up);

        }


    }

    private void OnDestroy()
    {
        GameManager.GameOver();
    }
}
