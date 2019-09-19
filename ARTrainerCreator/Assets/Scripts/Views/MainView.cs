using System;
using UnityEngine;

namespace ARTrainerCreator.View
{
    public interface IMainViewListener
    {
        void OnUpdateJoystick(MainView mainView, Vector2 vec);
    }

    public class MainView : MonoBehaviour
    {
        #region -- Public Property --

        [NonSerialized]
        public IMainViewListener listener;

        #endregion

        #region -- Private Property --

        [SerializeField]
        Joystick joystick;

        #endregion

        #region -- Override --

        void Update()
        {
            if (listener != null)
                listener.OnUpdateJoystick(this, new Vector2(joystick.Horizontal, joystick.Vertical));
        }

        #endregion
    }
}
