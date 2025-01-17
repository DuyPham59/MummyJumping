using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameState
{
    Starting,
    Playing,
    Gameover
}

public enum Gametag
{
    Platform,
    Player,
    LeftCorner,
    RightCorner,
    Collectable
}
public enum PrefKey
{
    BestScore
}
[System.Serializable]
public class CollectableItem
{
    public Collectable collectablePrefab;
    [Range(0f, 1f)]
    public float spawnRate;
}