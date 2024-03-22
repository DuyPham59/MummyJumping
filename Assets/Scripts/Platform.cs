using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public Transform cSpawnPoint;
    protected int m_id;
    public Rigidbody2D m_rb;
    protected Player m_player;

    public int ID { get => m_id; set => m_id = value; }
    protected virtual void Awake()
    {
        m_rb = GetComponent<Rigidbody2D>();
    }

    protected virtual void Start()
    {
        if (!GameManager.Ins) return;
        m_player = GameManager.Ins.player;
        if (cSpawnPoint)
        {
            GameManager.Ins.SpawnCollectable(cSpawnPoint);
        }
    }
    public virtual void PlatformAction()
    {

    }
}
