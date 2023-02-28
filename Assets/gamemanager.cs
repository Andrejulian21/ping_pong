using UnityEngine;
using TMPro;

public class gamemanager : MonoBehaviour
{
    [SerializeField] private TMP_Text puntuaci�n1text;
    [SerializeField] private TMP_Text puntuaci�n2text;

    [SerializeField] private Transform muslogod1Transform;
    [SerializeField] private Transform muslogod2Transform;
    [SerializeField] private Transform pollitococineroTransform;

    private int puntuaci�n1;
    private int puntuaci�n2;

    private static gamemanager instance;

    public static gamemanager Instance
    {
        get
        {
           if(instance == null)
            {
                instance = FindAnyObjectByType<gamemanager>();
            }
           return instance;
        }
    }

    public void Puntuaci�n1()
    {
        puntuaci�n1++;
        puntuaci�n1text.text = puntuaci�n1.ToString();
    }
    public void Puntuaci�n2()
    {
        puntuaci�n2++;
        puntuaci�n2text.text = puntuaci�n2.ToString();
    }
    public void Restart()
    {
        muslogod1Transform.position = new Vector2(muslogod1Transform.position.x, 0);
        muslogod2Transform.position = new Vector2(muslogod2Transform.position.x, 0);
        pollitococineroTransform.position = new Vector2(0,0);
    }
}
