using UnityEngine;

public class GameManager : MonoBehaviour
{
    Map map;
    public GameObject player;
    Vector3 playerStartPos;

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

    public void SetPlayerPos(Vector2 pos)
    {

    }

    private void Awake()
    {
        map=GameObject.FindObjectOfType<Map>();
        Vector2 pPos=map.Draw();
        playerStartPos = new Vector3(pPos.x,10f,pPos.y);
    }

    private void Start()
    {
        Instantiate(player, playerStartPos, Quaternion.identity);
    }



    void Update()
    {
        QuitGame();
    }
}
