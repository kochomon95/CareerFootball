using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CreatePlayerPanel : MonoBehaviour
{
    public TMP_InputField nameInput;
    public TMP_InputField heightInput;
    public TMP_InputField weightInput;
    public TMP_InputField nationalityInput;

    [Header("Position Buttons")]
    public Button openPositionButton;     // select position button
    public GameObject positionPanel;
    public Button cbButton;
    public Button cmButton;
    public Button cfButton;

    [Header("Foot Buttons")]
    public Button leftButton;
    public Button rightButton;
    public Button bothButton;

    [Header("Colors")]
    public Color selectedColor = Color.red;
    public Color normalColor = Color.white;

    private string selectedPosition = "";
    private string selectedFoot = "";

    void Start()
    {

        openPositionButton.onClick.AddListener(() => positionPanel.SetActive(true));
        // Position buttons
        cbButton.onClick.AddListener(() => SelectPosition("CB"));
        cmButton.onClick.AddListener(() => SelectPosition("CM"));
        cfButton.onClick.AddListener(() => SelectPosition("CF"));

        // Foot buttons
        leftButton.onClick.AddListener(() => SelectFoot("Left"));
        rightButton.onClick.AddListener(() => SelectFoot("Right"));
        bothButton.onClick.AddListener(() => SelectFoot("Both"));
    }

    void SelectPosition(string position)
    {
        selectedPosition = position;

        SetButtonColor(cbButton, position == "CB");
        SetButtonColor(cmButton, position == "CM");
        SetButtonColor(cfButton, position == "CF");

        SetButtonColor(openPositionButton, true);

        // Close the popup
        positionPanel.SetActive(false);
    }

    void SelectFoot(string foot)
    {
        selectedFoot = foot;

        SetButtonColor(leftButton, foot == "Left");
        SetButtonColor(rightButton, foot == "Right");
        SetButtonColor(bothButton, foot == "Both");
    }

    void SetButtonColor(Button button, bool isSelected)
    {
        Image img = button.GetComponent<Image>();
        img.color = isSelected ? selectedColor : normalColor;
    }

    public void OnStartCareerClicked()
    {
        Debug.Log("Button clicked");
        // Validate selections
        if (string.IsNullOrEmpty(selectedPosition) || string.IsNullOrEmpty(selectedFoot))
        {
            Debug.LogWarning("Please select a position and a preferred foot.");
            return;
        }

        PlayerData data = new PlayerData();

        data.playerName = nameInput.text;
        data.height = int.Parse(heightInput.text);
        data.weight = int.Parse(weightInput.text);
        data.position = selectedPosition;
        data.preferredFoot = selectedFoot;
        data.nationality = nationalityInput.text;

        // Generate attributes according to selected position
        data.attrs = StatGenerator.Generate(data.position);

        // Store the container in GameManager
        GameManager.Instance.player = data;
        Debug.Log("Saved: " + data.playerName + " | " + data.position + " | " + data.preferredFoot);
        SceneManager.LoadScene("PlayerHub");
    }
}