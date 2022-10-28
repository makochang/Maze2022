using UnityEngine;

public class Map : MonoBehaviour
{
    //マップデータ
    int[,] mapdata = {
        { 1, 2, 1, 2, 1, 2, 1, 2, 1 },
        { 3, 9, 0, 0, 0, 0, 0, 0, 3 },
        { 1, 2, 1, 2, 1, 0, 1, 2, 1 },
        { 3, 0, 0, 0, 0, 0, 0, 0, 3 },
        { 1, 0, 1, 0, 1, 2, 1, 0, 1 },
        { 3, 0, 0, 0, 3, 0, 0, 0, 3 },
        { 1, 2, 1, 2, 1, 0, 1, 0, 1 },
        { 3, 8, 0, 0, 0, 0, 3, 0, 3 },
        { 1, 2, 1, 2, 1, 2, 1, 2, 1 },
    };

    //マップのオフセット値（原点からどのくらいずらすのか）
    Vector2 offset = new Vector2(-1f, 1f);

    //壁や床のプレハブ
    public GameObject[] mapchip = new GameObject[4];

    public GameObject goalObject;

    /// <summary>
    /// マップを描画する
    /// </summary>
    public Vector2 Draw()
    {
        Vector2 playerPos = Vector2.zero;
        for (int i = 0; i < mapdata.GetLength(0); i++)
        {
            for (int j = 0; j < mapdata.GetLength(1); j++)
            {
                int index = mapdata[i, j];  //マップデータを参照してindexとする
                float x = j + offset.x;     //生成座標X
                float z = -i + offset.y;    //生成座標Y

                //特殊マップの処理
                if (index >= mapchip.Length || index < 0)
                {
                    switch (index)
                    {
                        case 8:
                            playerPos = new Vector2(x, z);
                            break;
                        case 9:
                            Instantiate(goalObject, new Vector3(x, 0f, z), Quaternion.identity);
                            break;
                        default:
                            break;
                    }
                    index = 0;
                }

                //マップオブジェクトを配置
                Instantiate(mapchip[index], new Vector3(x, 0f, z), Quaternion.identity);
            }
        }
        return playerPos;
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }
}
