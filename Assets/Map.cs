using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{
    //マップデータ
    int[,] mapdata = {
        { 1, 2, 1, 2, 1, 2, 1, 2, 1 },
        { 3, 0, 0, 0, 0, 0, 0, 0, 3 },
        { 1, 2, 1, 2, 1, 0, 1, 2, 1 },
        { 3, 0, 0, 0, 0, 0, 0, 0, 3 },
        { 1, 0, 1, 0, 1, 2, 1, 0, 1 },
        { 3, 0, 0, 0, 3, 0, 0, 0, 3 },
        { 1, 2, 1, 2, 1, 0, 1, 0, 1 },
        { 3, 0, 0, 0, 0, 0, 3, 0, 3 },
        { 1, 2, 1, 2, 1, 2, 1, 2, 1 },
    };

    //マップのオフセット値（原点からどのくらいずらすのか）
    Vector2 offset = new Vector2(-1f, 1f);

    //壁や床のプレハブ
    public GameObject[] mapchip = new GameObject[4];

    /// <summary>
    /// マップを描画する
    /// </summary>
    private void Draw()
    {
        for (int i = 0; i < mapdata.GetLength(0); i++)
        {
            for (int j = 0; j < mapdata.GetLength(1); j++)
            {
                int index = mapdata[i, j];  //マップデータを参照してindexとする
                float x = j + offset.x;     //生成座標X
                float z = -i + offset.y;    //生成座標Y
                Instantiate(mapchip[index], new Vector3(x, 0f, z), Quaternion.identity);
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        Draw();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
