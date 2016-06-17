using UnityEngine;
using System.Collections;

public class GameMgr : MonoBehaviour {
    private static GameMgr instance;

    public static GameMgr getInstance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType(typeof(GameMgr)) as GameMgr;
            }

            if (instance == null)
            {
                GameObject obj = new GameObject("GameMgr");
                instance = obj.AddComponent(typeof(GameMgr)) as GameMgr;
            }

            return instance;
        }
    }

    void OnApplicationQuit()
    {
        instance = null;
    }
    
    void Awake()
    {
        DontDestroyOnLoad(gameObject);

        m_PlayerColor = PLAYER.END;
    }

    public PLAYER m_PlayerColor;
    
}
