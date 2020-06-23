using UnityEngine;
//註解:用來說紀錄等等.. 只會在此腳本內容看到
//摘要summary:描述此內容,會在其他教本內看到,提高維護性,擴充性
//新增的C#放在專案內為藍圖
//放在場景物件上為實體物件
/// <summary>
/// 定義汽車物件
/// </summary>
public class CAR: MonoBehaviour
{
    //認識第一個成員:欄位field - 儲存物件資料
    //資料類型
    //cc數   - 200 - 整數 int
    //重量    - 100.9 - 浮點數 float
    //品牌    -BMW     -  字串 string
    //剎車    -是否開啟   -布林值bool

    //定義欄位語法:
    // 修飾詞資料類型 欄位名稱;
    //公開public:允許其他類別存取,顯示在屬性面板(Inspector)
    //私人private(預設):不允許,不顯示
    //int ,float為0
    //string為""
    //bool為false
    //欄位屬性attribute:Unity 提供用於輔助欄位的功能
    //語法:[屬性名稱值(值)]
    //標題[Header(字串)]
    //範圍[Range(最大值,最小值)],僅限於數值類型資料 int,float
    /// <summary>
    /// 汽車的cc數
    /// </summary>
    [Header("汽車的cc數"), Tooltip("這個欄位是描述汽車的CC數")]
   public int cc = 2000;
    /// <summary>
    /// 汽車噸位
    /// </summary>
    [Header("汽車的重量"), Tooltip("這個欄位是存放汽車噸位")]
    public float weight = 100.9f;
    /// <summary>
    /// 汽車的品牌
    /// </summary>
    [Header("汽車的品牌"), Tooltip("這個欄位是描述汽車的品牌")]
    public string brand = "BMW";
    /// <summary>
    /// 是否剎車
    /// <summary>
    [Header("是否剎車"),Tooltip("判定汽車是否剎車")]
    public bool brake = false;
    }