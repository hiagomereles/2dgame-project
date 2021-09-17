using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageableController : MonoBehaviour
{
    void OnTriggerStay2D(Collider2D other)
    {
        RubyController controller = other.GetComponent<RubyController>(); //garantir que só diminua a vida do personagem.

        if( controller != null)
        {
                controller.changeHealth(-1);
        }
    }
}
