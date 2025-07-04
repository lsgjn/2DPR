using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class DoTween : MonoBehaviour
{
    // UI 오브젝트 연결
    public Text goldText;
    public Text woodText;
    public Text stoneText;
    public Text turnText;
    public Slider progressBar;
    public Button[] choiceButtons;

    // 자원 값 예시
    int gold = 100, wood = 50, stone = 30, turn = 1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 자원 텍스트 DOTween 애니메이션 예시
        UpdateResourceUI();
        UpdateTurnUI();
        UpdateProgressBar(0f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void UpdateResourceUI()
    {
        DOTween.To(() => gold, x => { gold = x; goldText.text = $"Gold: {gold}"; }, gold + 10, 0.5f);
        DOTween.To(() => wood, x => { wood = x; woodText.text = $"Wood: {wood}"; }, wood + 5, 0.5f);
        DOTween.To(() => stone, x => { stone = x; stoneText.text = $"Stone: {stone}"; }, stone + 3, 0.5f);
    }

    public void UpdateTurnUI()
    {
        turn++;
        turnText.DOText($"Turn: {turn}", 0.3f);
    }

    public void UpdateProgressBar(float targetValue)
    {
        progressBar.DOValue(targetValue, 0.5f);
    }

    // 선택지 버튼에 연결할 함수 예시
    public void OnChoiceSelected(int idx)
    {
        // 선택지에 따라 진행도 증가
        UpdateProgressBar(progressBar.value + 0.2f);
    }
}
