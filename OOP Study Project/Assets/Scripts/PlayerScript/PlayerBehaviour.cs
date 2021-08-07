using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SkagoGames.PlayerNC
{
    public class InheritanceFromPlayerClass : MonoBehaviour
    {
        protected virtual void VPlayerSetup() { }
        protected virtual void VPlayerLoop() { }
        protected virtual void VPlayerFixedLoop() { }

        protected virtual void OnPlayerEnter(Collider otherP) { }

        protected virtual void OnPlayerEnter2D(Collider2D otherP2D) { }
    }

    public class PlayerBehaviour : InheritanceFromPlayerClass
    {
        private void Start()
        {
            VPlayerSetup();
        }
        private void Update()
        {
            VPlayerLoop();
        }

        private void FixedUpdate() 
        {
            VPlayerFixedLoop();
        }

        private void OnTriggerEnter(Collider other) 
        {
           OnPlayerEnter(other);
        }

        private void OnTriggerEnter2D(Collider2D other) 
        {
            OnPlayerEnter2D(other);
        }
    }
}