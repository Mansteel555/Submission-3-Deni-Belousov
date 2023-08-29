using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    [SerializeField] private GameObject player;
    public static GameObject Player {
        get; set; }


    private void Awake()
    {
        Player = player;
    }
    
}
