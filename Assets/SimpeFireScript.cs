using UnityEngine;
using System.Collections;

public class SimpeFireScript : MonoBehaviour {
    public Transform turret;
    public Rigidbody recoilPoint;
    public int recoilPower;
    public float timer;
    private float zeroSeconds = 0f;

    public Rigidbody projectile;
    public float POWER;
    private Vector3 projectileSpawn;

   
   
    void Start () {
        
    }

    
    public void FixedUpdate()
    {
        projectileSpawn = new Vector3(turret.position.x, turret.position.y , turret.position.z);
        
        zeroSeconds += Time.deltaTime;

        if ((Input.GetKey("space"))&&(zeroSeconds >= timer ))
        { 
            recoilPoint.AddRelativeForce(0f,0f,recoilPower);
        }
        if ((Input.GetKey("space")) && (zeroSeconds >= timer))
        {
            Rigidbody shot = Instantiate(projectile, projectileSpawn, turret.rotation) as Rigidbody;
            shot.AddForce(turret.transform.forward * POWER);
            zeroSeconds = 0f;
        }
    }
}
