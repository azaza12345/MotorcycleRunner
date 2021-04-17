using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySuicide : EnemyController
{
    private void FixedUpdate()
    {
        MoveEnemy();
    }

    private void MoveEnemy()
    {
        move = (player.transform.position - transform.position).normalized;
        enemyRb.velocity = move * enemySpeed;
    }
}
