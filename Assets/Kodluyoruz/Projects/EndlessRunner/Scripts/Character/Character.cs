﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public enum CharacterControllerType { Player, AI}

public class Character : MonoBehaviour
{

    public CharacterControllerType CharacterControllerType = CharacterControllerType.Player;

    private Rigidbody rigidbody;
    public Rigidbody Rigidbody { get { return (rigidbody == null) ? rigidbody = GetComponent<Rigidbody>() : rigidbody; } }

    private Collider collider;
    public Collider Collider { get { return (collider == null) ? collider = GetComponent<Collider>() : collider; } }

    #region Events
    [HideInInspector]
    public UnityEvent OnCharacterHit = new UnityEvent();
    [HideInInspector]
    public UnityEvent OnCharacterHeal = new UnityEvent();
    [HideInInspector]
    public UnityEvent OnCharacterDie = new UnityEvent();
    [HideInInspector]
    public UnityEvent OnCharacterRevive = new UnityEvent();
    [HideInInspector]
    public UnityEvent OnCharacterJump = new UnityEvent();
    [HideInInspector]
    public UnityEvent OnCharacterSlide = new UnityEvent();
    [HideInInspector]
    public UnityEvent OnCharacterSwitchLane = new UnityEvent();

    #endregion

    private bool isDead;
    public bool IsDead { get { return (isDead); } set { isDead = value; } }

    private bool isControlable;
    public bool IsControlable { get { return isControlable; } set { isControlable = value; } }

    private void OnEnable()
    {
        if (Managers.Instance == null)
            return;

        
    }

    private void OnDisable()
    {
        if (Managers.Instance == null)
            return;

    }


    public void DamageCharacter()
    {

    }
    public void HealCharacter()
    {

    }

    public void KillCharacter()
    {
        
    }

    public void ReviveCharacter()
    {
      
    }


    private void OnTriggerEnter(Collider other)
    {
       
    }

}
