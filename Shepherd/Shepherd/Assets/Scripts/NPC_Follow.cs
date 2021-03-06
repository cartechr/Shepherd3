using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPC_Follow : MonoBehaviour
{
    //Transform that NPC has to follow
    public Transform transformToFollow;
    //NavMesh Agent variable
    NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        //Follow the player
        agent.destination = transformToFollow.position;
    }
}

// https://sharpcoderblog.com/blog/npc-follow-player-in-unity-3d //