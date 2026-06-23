using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;

public class SlotMachineController : MonoBehaviour
{
    public Reel reel1;
    public Reel reel2;
    public Reel reel3;

    public Button spinButton;
    [SerializeField] private Vector2 pressedSize;
    [SerializeField] private Vector2 pressedPosition;

    private Vector2 originalSize;
    private Vector3 originalPosition;
    public TMP_Text resultText;
    Sprite originalSprite;
    public Sprite changedSprite;
    bool spinning;

    private RectTransform rect;

    private void Start()
    {
        rect = spinButton.GetComponent<RectTransform>();

        originalSize = rect.sizeDelta;
        originalPosition = rect.localPosition;
    }
    public void Spin()
    {
        if (spinning)
            return;

        spinning = true;

        originalSprite = spinButton.image.sprite;

        spinButton.image.sprite = changedSprite;

        rect.sizeDelta = pressedSize;
        rect.localPosition = pressedPosition;

        StartCoroutine(SpinRoutine());
    }
    IEnumerator SpinRoutine()
    {
        spinning = true;

        spinButton.interactable = false;

        resultText.gameObject.SetActive(false);

        float timer = 0f;

        int r1 = GetWeightedResult();
        int r2 = GetWeightedResult();
        int r3 = GetWeightedResult();

        while (timer < 2f)
        {
            reel1.Randomize();
            reel2.Randomize();
            reel3.Randomize();

            timer += 0.04f;

            yield return new WaitForSeconds(0.04f);
        }

        reel1.SetFinal(r1);

        yield return new WaitForSeconds(0.3f);

        reel2.SetFinal(r2);

        yield return new WaitForSeconds(0.3f);

        reel3.SetFinal(r3);

        yield return new WaitForSeconds(0.2f);

        CheckWin(r1, r2, r3);

        resultText.gameObject.SetActive(true);

        spinButton.interactable = true;

        spinning = false;
        spinButton.image.sprite = originalSprite;

        rect.sizeDelta = originalSize;
        rect.localPosition = originalPosition;
    }
    int GetWeightedResult()
    {
        int rand = Random.Range(0, 100);

        if (rand < 40)
            return 0;

        if (rand < 70)
            return 1;

        if (rand < 90)
            return 2;

        return 3;
    }

    void CheckWin(int a, int b, int c)
    {
        if (a == b && b == c)
        {
            resultText.text =
                "WIN +" + GetPayout(a);
        }
        else
        {
            resultText.text =
                "TRY AGAIN";
        }
    }

    int GetPayout(int symbol)
    {
        switch (symbol)
        {
            case 0: return 10;
            case 1: return 20;
            case 2: return 50;
            case 3: return 100;
        }

        return 0;
    }
}