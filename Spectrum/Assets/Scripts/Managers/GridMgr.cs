using UnityEngine;
using System.Collections;

public class GridMgr : MonoBehaviour
{

    public int m_iGridIdx;

    public int m_iXcount; //  Recommand NOT Even!
    public int m_iYcount; //  Recommand NOT Even!

    public Vector2 m_fStartPos;

    public float m_fXsize;
    public float m_fYsize;
    
    void Update()
    {
        Picking();
    }


    void Picking()
    {
        Vector2 vPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        m_iGridIdx = (int)(System.Math.Round((vPosition.y - m_fStartPos.y + (m_fYsize / 2)) / m_fYsize) * m_iXcount * -1) + (int)(System.Math.Round((vPosition.x - m_fStartPos.x - (m_fXsize / 2)) / m_fXsize));

    }
    
}
