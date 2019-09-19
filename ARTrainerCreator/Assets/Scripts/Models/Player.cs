using System;
using UnityEngine;

namespace ARTrainerCreator.Model
{
    public class Player : MonoBehaviour
    {
        #region -- Public --

        public void Translate(Vector2 vec)
        {
            transform.position += new Vector3(vec.x, vec.y, 0);
        }

        #endregion
    }
}