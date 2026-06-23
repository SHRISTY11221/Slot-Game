using UnityEngine;
using UnityEngine.UI;

public class Reel : MonoBehaviour
{
    public Image top;
    public Image middle;
    public Image bottom;

    public Sprite[] symbols;

    public int CurrentResult { get; private set; }

    public void Randomize()
    {
        int topIndex = Random.Range(0, symbols.Length);

        int middleIndex;
        do
        {
            middleIndex = Random.Range(0, symbols.Length);
        }
        while (middleIndex == topIndex);

        int bottomIndex;
        do
        {
            bottomIndex = Random.Range(0, symbols.Length);
        }
        while (bottomIndex == middleIndex);

        top.sprite = symbols[topIndex];
        middle.sprite = symbols[middleIndex];
        bottom.sprite = symbols[bottomIndex];
    }

    public void SetFinal(int result)
    {
        CurrentResult = result;

        middle.sprite = symbols[result];

        int topIndex;
        do
        {
            topIndex = Random.Range(0, symbols.Length);
        }
        while (topIndex == result);

        int bottomIndex;
        do
        {
            bottomIndex = Random.Range(0, symbols.Length);
        }
        while (bottomIndex == result);

        top.sprite = symbols[topIndex];
        bottom.sprite = symbols[bottomIndex];
    }
}