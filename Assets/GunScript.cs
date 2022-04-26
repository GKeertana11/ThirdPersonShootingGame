using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour
{
    [SerializeField]
    [Range(0.5f, 1.5f)]
    float fireRate = 1.0f;
    [Range(1f, 10f)]
    float damageRate = 1.0f;
    float timer;
    public Transform spawnPoint;
    public Vector3 offset;

   public  ParticleSystem particle;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        timer = timer + Time.deltaTime;
        if(timer>=fireRate)
        {
            if(Input.GetButton("Fire1"))
            {
                timer = 0f;
                ToFireGun();
            }
        }
    }
    private void ToFireGun()
    {
        particle.Play();
        Debug.DrawRay(spawnPoint.transform.position+offset, transform.forward * 100, Color.red,2f);
        Ray ray = new Ray(spawnPoint.position, transform.forward);
        RaycastHit HitInfo;
        if(Physics.Raycast(ray,out HitInfo,100f))
        {
          
            //need to shoot the enemy
           var health= HitInfo.collider.GetComponent<EnemyScript>();
            if(health!=null)
            {
                health.Damage(5);
            }

        }
       
    }
}
