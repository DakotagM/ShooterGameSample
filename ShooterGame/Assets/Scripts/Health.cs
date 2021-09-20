/****
 * Created by: Dakota Mitchell
 * Date: Sept 20,2021
 * 
 * Last Edited by:
 * Last updated: Sept 20,2021
 * 
 * Controls Health
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    /*Variables*/
    public bool DestroyonDeath = true;
    public GameObject DeathParticlesPrefab = null;
    [SerializeField] private float _HealthPoints = 100f;
    public float HealthPoints
    {
        get { return _HealthPoints; }
        set
        {
            _HealthPoints = value;
            if (HealthPoints <= 0)
            {
                SendMessage("Die", SendMessageOptions.DontRequireReceiver);

                if (DeathParticlesPrefab != null)
                {
                    Instantiate(DeathParticlesPrefab, transform.position, transform.rotation);
                }
                if (DestroyonDeath)
                {
                    Destroy(gameObject);
                }
            }
        }
    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //debug Health
        if(Input.GetKeyDown(KeyCode.Space))
        {
            HealthPoints = 0;
        }
    }
}
