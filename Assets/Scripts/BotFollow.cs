using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.AI;
using UnityEngine.AI;


public class BotFollow : MonoBehaviour
{ 
    [SerializeField] public NavMeshAgent bot;
    [SerializeField] public Transform Player; 
    void Update()
    {
        bot.SetDestination(Player.position);
    }
}
