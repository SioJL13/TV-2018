namespace VRTK.Examples
{
    using UnityEngine;
    using System.Collections;
    using System.Collections.Generic;

    public class PauseAction: MonoBehaviour
    {

        public GameObject PauseMenu;  //Make reference of this gameobject. 

        private void Start()
        {

            PauseMenu.SetActive(false);

            if (GetComponent<VRTK_ControllerEvents>() == null)
            {
                VRTK_Logger.Error(VRTK_Logger.GetCommonMessage(VRTK_Logger.CommonMessageKeys.REQUIRED_COMPONENT_MISSING_FROM_GAMEOBJECT, "VRTK_ControllerEvents_ListenerExample", "VRTK_ControllerEvents", "the same"));
                return;
            }

            //Setup controller event listeners
            GetComponent<VRTK_ControllerEvents>().ButtonTwoPressed += new ControllerInteractionEventHandler(DoButtonTwoPressed); //Detect the upper main button of the HTC VIVE controller. 
            GetComponent<VRTK_ControllerEvents>().ButtonTwoReleased += new ControllerInteractionEventHandler(DoButtonTwoReleased);
        }

        private void DebugLogger(uint index, string button, string action, ControllerInteractionEventArgs e) //Debugged message for testing only. 
        {
            VRTK_Logger.Info("Controller on index '" + index + "' " + button + " has been " + action
                    + " with a pressure of " + e.buttonPressure + " / trackpad axis at: " + e.touchpadAxis + " (" + e.touchpadAngle + " degrees)");
        }

        private void DoButtonTwoPressed(object sender, ControllerInteractionEventArgs e)
        {
            DebugLogger(VRTK_ControllerReference.GetRealIndex(e.controllerReference), "BUTTON TWO", "pressed down", e);

            //Stops the game run time. 
            if (Time.timeScale == 1)
            {
                Time.timeScale = 0;
                PauseMenu.SetActive(true);
            }
            else
            {
                Time.timeScale = 1;
                PauseMenu.SetActive(false);
            }
        }

        private void DoButtonTwoReleased(object sender, ControllerInteractionEventArgs e)
        {
            DebugLogger(VRTK_ControllerReference.GetRealIndex(e.controllerReference), "BUTTON TWO", "released", e);
        }
    }
}
