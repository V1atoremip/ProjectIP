using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballScript : MonoBehaviour
{
    public float value = 100;
    public float speed;
    public float lifetime;
    public float damage = 10;

    void FixedUpdate()
    {
        MoveFixedUpdate();
    }
    
    private void MoveFixedUpdate()
    {
        transform.position += transform.forward * speed * Time.fixedDeltaTime;
    }
    private void OnCollisionEnter(Collision collision)
    {
        DamageEnemy(collision);
        DestroyFireballScript();
    }
    private void DamageEnemy(Collision collision)
    {
        var enemyHealth = collision.gameObject.GetComponent<EnemyHealth>();
        if (enemyHealth != null)
        {
            enemyHealth.value -= damage;
            if (enemyHealth.value <=0)
            {
                Destroy(enemyHealth.gameObject);
            }
        }
    }
    public void DestroyFireballScript()
    {
        Destroy(gameObject);
    }

    private void Start()
    {
        Invoke("DestroyFireballScript", lifetime);
    }
}



