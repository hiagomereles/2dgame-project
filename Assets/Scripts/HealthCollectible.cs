using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCollectible : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other)
    {
        RubyController controller = other.GetComponent<RubyController>(); //garantir que só aumente a vida do personagem.

        if(controller != null)
        {
            if(controller.health < controller.maxHealth)
            {
                controller.changeHealth(1);
                Destroy(gameObject);
            }
            
        }
        
    }
}
