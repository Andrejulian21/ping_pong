using UnityEngine;
using TMPro;

public class gamemanager : MonoBehaviour
{
    [SerializeField] private TMP_Text puntuación1text;
    [SerializeField] private TMP_Text puntuación2text;

    [SerializeField] private Transform muslogod1Transform;
    [SerializeField] private Transform muslogod2Transform;
    [SerializeField] private Transform pollitococineroTransform;

    private int puntuación1;
    private int puntuación2;

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

    public void Puntuación1()
    {
        puntuación1++;
        puntuación1text.text = puntuación1.ToString();
    }
    public void Puntuación2()
    {
        puntuación2++;
        puntuación2text.text = puntuación2.ToString();
    }
    public void Restart()
    {
        muslogod1Transform.position = new Vector2(muslogod1Transform.position.x, 0);
        muslogod2Transform.position = new Vector2(muslogod2Transform.position.x, 0);
        pollitococineroTransform.position = new Vector2(0,0);
    }
}
