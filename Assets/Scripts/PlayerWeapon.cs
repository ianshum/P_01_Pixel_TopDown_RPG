using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeapon : CharacterWeapon
{
    protected override void OnCollide(Collider2D collider)
    {
        if(collider.tag == "Fighter")
        {
            if(collider.name == "Player")
                return;

            collider.SendMessage("ReceiveDamage", _currentDamage);
        }
    }
}
