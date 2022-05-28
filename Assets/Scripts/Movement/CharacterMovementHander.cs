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
    {//��ȡ���Կͻ�������
        if(GetInput(out NetworkInputData networkInputData))
        {
            //�ƶ�
            Vector3 moveDirection = transform.forward * networkInputData.movementInput.y + transform.right * networkInputData.movementInput.x;
            moveDirection.Normalize();

            networkCharacterControllerPrototypeCustom.Move(moveDirection);
        }
    }
}
