using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MainMenuManager : MonoBehaviour
{
    public TMP_InputField nameInput;
    public TMP_InputField regInput;

    public void ContinueLab()
    {
        string studentName = nameInput.text;
        string regNumber = regInput.text;

        Debug.Log("Student Name: " + studentName);
        Debug.Log("Registration Number: " + regNumber);

        SceneManager.LoadScene("Experiment2Scene");
    }
}