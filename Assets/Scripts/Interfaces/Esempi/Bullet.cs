using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private void OnTriggerEnter(Collider collider)
        {
        /* come controlleresti se l'oggetto colpito è un nemico senza l'uso di interfacce
        Enemy enemy = collider.GetComponent<Enemy>();
        if(enemy != null){
            enemy.Damage();
        }*/

        // controllo tramite l'uso di interfacce
        IDamageable damageable = collider.GetComponent<IDamageable>();
        if(damageable != null){
            damageable.Damage();
        }

        }
}
