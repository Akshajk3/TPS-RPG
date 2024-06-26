using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DarkSouls
{
    public class PlayerManager : MonoBehaviour
    {
        InputHandler inputHandler;
        Animator anim;

        void Start()
        {
            inputHandler = GetComponent<InputHandler>();
            anim = GetComponentInChildren<Animator>();
        }

        void Update()
        {
            inputHandler.isInteracting = anim.GetBool("isInteracting");
            inputHandler.rollFlag = false;
        }
    }
}