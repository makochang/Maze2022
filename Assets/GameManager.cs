using UnityEngine;

public class GameManager : MonoBehaviour
{
    /// <summary>
    /// �Q�[���{�̂��I������
    /// </summary>
    private void QuitGame()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            //Unity�G�f�B�^�[�̏ꍇ
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#endif
            //���s�t�@�C���̏ꍇ
#if UNITY_STANDALONE
            Application.Quit();
#endif
        }
    }

    void Update()
    {
        QuitGame();
    }
}
