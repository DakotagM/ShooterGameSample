using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProxyDamage : MonoBehaviour
{

    //Variables

    public float DamageRate = 10f; //dps

    private void OnTriggerStay(Collider other)
    {
        Health H = other.gameObject.GetComponent<Health>();

        if(H == null) { return; }

        H.HealthPoints -= DamageRate * Time.deltaTime;
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
