﻿using System;
using UnityEngine;


namespace RollABall
{
    public sealed class SimpleBuffView : MonoBehaviour, IImprover
    {
        #region Fields

        //public event Action<SimpleBuffView>

        #endregion


        #region UnityMethods

        private void OnTriggerEnter(Collider other)
        {
            
        }

        #endregion


        #region Methods

        public void Boost<T>(T target) where T : IImprovable
        {

        }

        #endregion
    }
}