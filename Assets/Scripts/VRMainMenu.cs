using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class VRMenuManager : MonoBehaviour
{
    public TMP_InputField nameInput;
    public TMP_InputField regInput;

    public void ContinueLab()
    {
        string studentName = nameInput.text;
        string regNumber = regInput.text;

        Debug.Log("Student Name: " + studentName);
        Debug.Log("Registration: " + regNumber);

        SceneManager.LoadScene("Experiment2Scene");
    }
}