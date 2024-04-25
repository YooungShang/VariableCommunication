namespace VariablesCore.Variable;

/// <summary>
/// 读变量
/// </summary>
public class ReadVariable : IVariable
{
    /// <summary>
    /// 变量名称
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// 变量地址
    /// </summary>
    public int Address { get; set; }

    /// <summary>
    /// 变量值
    /// </summary>
    public object Value { get; set; }

    /// <summary>
    /// 值类型
    /// </summary>
    public ValueType Type { get; set; }
}