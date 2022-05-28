using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fusion;


public class CharacterMovementHander : NetworkBehaviour
{
    NetworkCharacterControllerPrototypeCustom networkCharacterControllerPrototypeCustom;


    private void Awake()
    {
        networkCharacterControllerPrototypeCustom = GetComponent<NetworkCharacterControllerPrototypeCustom>();
    }



    void Start()
    {
        
    }

    public override void FixedUpdateNetwork()
    {//获取来自客户端输入
        if(GetInput(out NetworkInputData networkInputData))
        {
            //移动
            Vector3 moveDirection = transform.forward * networkInputData.movementInput.y + transform.right * networkInputData.movementInput.x;
            moveDirection.Normalize();

            networkCharacterControllerPrototypeCustom.Move(moveDirection);
        }
    }
}
