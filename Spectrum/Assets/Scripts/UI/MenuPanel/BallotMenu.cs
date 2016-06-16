using UnityEngine;
using System.Collections;

public class BallotMenu : MonoBehaviour
{
    UISprite m_BallotCircle;
    enum MENU_UI { VOTE, OPTION, EXIT, CONFIRM, CANCEL };
    MENU_UI m_menu_ui;

    void Start()
    {
        m_BallotCircle = transform.GetChild(1).GetComponent<UISprite>();

        switch (gameObject.name)
        {
            case "vote":
                m_menu_ui = MENU_UI.VOTE;
                break;

            case "option":
                m_menu_ui = MENU_UI.OPTION;
                break;

            case "exit":
                m_menu_ui = MENU_UI.EXIT;
                break;

            case "confirm":
                m_menu_ui = MENU_UI.CONFIRM;
                break;

            case "cancel":
                m_menu_ui = MENU_UI.CANCEL;
                break;
        }
    }

    void OnClick()
    {
        GameObject.Find("MenuPanel").BroadcastMessage("DisableButton");

        

        switch(m_menu_ui)
        {
            case MENU_UI.VOTE:
                GameObject.Find("MenuPanel").GetComponent<TweenPosition>().PlayForward();
                break;

            case MENU_UI.OPTION:
                break;

            case MENU_UI.EXIT:
                break;

            case MENU_UI.CONFIRM:
                break;

            case MENU_UI.CANCEL:
                GameObject.Find("MenuPanel").BroadcastMessage("DisableThisPortrait");
                GameObject.Find("MenuPanel").GetComponent<TweenPosition>().PlayReverse();
                break;
        }

        m_BallotCircle.spriteName = "button_on";
    }

    public void DisableButton()
    {
        m_BallotCircle.spriteName = "button_off";
    }
}
