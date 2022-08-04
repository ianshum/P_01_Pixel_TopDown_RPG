using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterWeapon : Collidable
{
    #region class members
    private Animator _animator;
    private float _lastAttackTime;
    protected Damage _currentDamage;
    public bool _isAttacking = false;
    #endregion

    #region accessors
    #endregion

    protected override void Start()
    {
        base.Start();
        _animator = GetComponent<Animator>();
    }

    public void TryAttack(Damage damage)
    {
        if(Time.time - _lastAttackTime <= damage.cooldown)
            return;

        _lastAttackTime = Time.time;
        _animator.SetTrigger("Attack");
        _currentDamage = damage;
    }

}
