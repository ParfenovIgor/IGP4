using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level2 : AbstractLevel
{
    public AbstractEnemyGenerator EnemyGenerator;

    public override AbstractEnemyGenerator GetEnemyGenerator() {
        return Instantiate(EnemyGenerator);
    }
}
