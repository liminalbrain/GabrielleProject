using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private GameObject attackArea = defult;

    private bool attacking = false;

    private float timeToAttack = 0.25f;
    private float timer = 0f;


    // Start is called before the first frame update
    void Start()
    {
        attackArea = transform.GetChild(0)Gameobject;
    }

    // Update is called once per frame
    void Update()
    {
        if (input.GetKeyDown(Keycode.Space))
    }


    private void Attack()
    {
        attacking = Attack()
         = attackArea.SetActive(attacking);
    }


}