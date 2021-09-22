/****
 * Created by: Dakota Mitchell
 * Date: Sept 22,2021
 * 
 * Last Edited by:
 * Last updated: Sept 22,2021
 * 
 * Controls Ammo
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour
{
    /*Variables*/
    public float damage = 100f;
    public float Lifetime = 2f;



    private void OnEnable()
    {
        CancelInvoke();
        Invoke("Die", Lifetime);

    }


    private void OnTriggerEnter(Collider other)
    {
        Health H = other.gameObject.GetComponent<Health>();

        H.HealthPoints -= damage;
        Die();
    }

    void Die()
    {
        gameObject.SetActive(false);
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
