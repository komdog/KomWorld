
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class PlayerModSetter : UdonSharpBehaviour
{

    [Header("Player Settings")]
    [SerializeField] float jumpHeight = 10;
    [SerializeField] float walkSpeed = 5;
    [SerializeField] float runSpeed = 10;
    [SerializeField] float gravityStrength = 1;

    void Start()
    {

        var playerApi = Networking.LocalPlayer;

        if(playerApi != null)
        {
            playerApi.SetJumpImpulse(jumpHeight);
            playerApi.SetRunSpeed(runSpeed);
            playerApi.SetWalkSpeed(walkSpeed);
            playerApi.SetStrafeSpeed(walkSpeed);
            playerApi.SetGravityStrength(gravityStrength);
        }
        
    }

    
}
