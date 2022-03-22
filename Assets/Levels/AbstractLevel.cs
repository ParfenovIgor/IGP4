using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractLevel : MonoBehaviour
{
    public abstract AbstractEnemyGenerator GetEnemyGenerator();
}
