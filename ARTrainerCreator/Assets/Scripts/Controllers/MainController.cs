using UnityEngine;
using ARTrainerCreator.View;
using ARTrainerCreator.Model;

namespace ARTrainerCreator.Controller
{
	public class MainController : MonoBehaviour, IMainViewListener
	{
        #region -- Private Property --

        [SerializeField]
        Player player;

        [SerializeField]
		MainView mainView;

		#endregion

		#region -- IMainViewListener --

		public void OnUpdateJoystick(MainView mainView, Vector2 vec)
		{
            player.Translate(vec * 0.02f);
		}

		#endregion

		#region -- Override --

		void Start()
		{
			mainView.listener = this;
		}

		#endregion
	}
}
