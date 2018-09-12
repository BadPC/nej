public class Repetition : MonoBehaviour
{
    public bool doPrint;
    public int i;
    public float f;
    public double d;
    public string s;

    public string[] texter;

    // Use this for initialization
    private void Start()
    {
        Story();
    }

    public void RepetitionsFunction()
    {
        if (doPrint == true)
        {
            print("I'm printing my dude");
        }
        else
        {
            Debug.LogWarning("Oh fricc run my dude");
        }
    }

    public void Story()
    {
        for (int i = 0; i < texter.Length; i++)
        {
            Debug.Log(texter[0]);
        }
    }

    // Update is called once per frame
    private void Update()
    {
    }
}