using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPlayerInit
{
    void IFPlayerSetup();
}

public interface IPlayerLoops
{
    void IFPlayerLoop();
    void IFPlayerFixedLoop();
}

public class PlayerBehaviour : MonoBehaviour, IPlayerInit, IPlayerLoops
{
    void Start()
    {
        StartCoroutine(CPlayerInit());

        StartCoroutine(CPlayerLoop());
        StartCoroutine(CPlayerFixedLoop());
    }

    void OnTriggerEnter(Collider other) 
    {
        OnPlayerEnter(other);
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        OnPlayerEnter2D(other);
    }

    private IEnumerator CPlayerInit()
    {
        Debug.Log("CPlayerInit");
        IFPlayerSetup();
        yield break;
    }

    private IEnumerator CPlayerLoop()
    {
        while(true)
        {
            yield return null;
            Debug.Log("CPlayerLoop");
            IFPlayerLoop();
        }
    }

    private IEnumerator CPlayerFixedLoop()
    {
        while(true)
        {
            yield return new WaitForFixedUpdate();
            Debug.Log("CPlayerFixedLoop");
            IFPlayerFixedLoop();
        }
    }

    public virtual void IFPlayerSetup() { }
    public virtual void IFPlayerLoop() { }
    public virtual void IFPlayerFixedLoop() { }

    public virtual void OnPlayerEnter(Collider otherP) { }

    public virtual void OnPlayerEnter2D(Collider2D otherP2D) { }
}
