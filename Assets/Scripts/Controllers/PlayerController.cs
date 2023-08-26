using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerController", menuName = "InputController/PlayerController")]
public class PlayerController : InputController
{
    public override float RetrieveMoveInput(){
        return Input.GetAxisRaw("Horizontal");
    }

    public override bool RetriveJumpInput(){
        return Input.GetButtonDown("Jump");
    }
}
