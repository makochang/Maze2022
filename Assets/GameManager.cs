using UnityEngine;

public class GameManager : MonoBehaviour
{
    /// <summary>
    /// ゲーム本体を終了する
    /// </summary>
    private void QuitGame()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            //Unityエディターの場合
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#endif
            //実行ファイルの場合
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
