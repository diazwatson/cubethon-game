using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class Number : MonoBehaviour
{
    public Text numberText;

    // Start is called before the first frame update
    void Start()
    {
        var buildIndex = SceneManager.GetActiveScene().buildIndex - 1;
        numberText.text = buildIndex.ToString();
    }

    // Update is called once per frame
    void Update()
    {
    }
}