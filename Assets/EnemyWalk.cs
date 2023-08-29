using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWalk : MonoBehaviour
{
    private const float ENEMY_SPEED = 2;

    void Update()
    {
       transform.position = Vector2.MoveTowards(transform.position, GameManager.Player.transform.position, ENEMY_SPEED * Time.deltaTime);
       
    }
}
