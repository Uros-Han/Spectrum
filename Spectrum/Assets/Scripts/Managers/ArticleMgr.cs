using UnityEngine;
using System.Collections;

public class ArticleMgr : MonoBehaviour {

    public int[] m_adBlockIdx;

	// Use this for initialization
	void Start () {
        m_adBlockIdx = new int[5];
        RandomingAdBlock();

        for (int i = 0; i < 5; ++i)
        {
            transform.GetChild(m_adBlockIdx[i]).GetComponent<SpriteRenderer>().enabled = false;
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void RandomingAdBlock()
    {
        for (int i = 0; i < 5; ++i)
        {
            bool bRedo = false;
            int iTmp = 0;

            do
            {
                iTmp = Random.Range(0, 35);
                bRedo = false;

                if (i == 0)
                    break;

                for (int j = 0; j < i; ++j)
                {
                    if (m_adBlockIdx[j].Equals(iTmp))
                    {
                        bRedo = true;
                        break;
                    }
                }

            } while (bRedo);

            m_adBlockIdx[i] = iTmp;
        }
    }
}
