## ���Я��������Parameterize Method��

**����������**

�ڳ��ԶԼ�����صĺ���������������ʱ���һ��ȴ�����ѡһ������������Ӳ�����ͬʱ���������������������������������Χ��������£�ͨ����λ���м�ķ�Χ��ʼ���ֽϺá�����������ѡ���� middleBand ��������Ӳ�����Ȼ����������ĵ���������Ӧ����

middleBand ʹ��������������ֵ���� 100 �� 200���ֱ�����м䵵�Ρ����½���Ͻ硣�������øı亯��������124������������������ͬʱ˳�ָ������ĸ�����ʹ����õر���������֮��ĺ��塣

```csharp
public Dollars BaseCharge (double usage)
{
    if (usage < 0)
    {
        return new Dollars (0);
    }
    
    double amount = bottomBand (usage) * 0.03 + withinBand (usage, 100, 200) * 0.05 + topBand (usage) * 0.07;
    return new Dollars (amount);
}

private double WithinBand(double usage, double bottom, double top)
{
    return usage > 100 ? Math.min(usage, 200) - 100 : 0;
}
```



�ں������ڲ�����һ����������Ϊʹ���´���Ĳ�����

```csharp
private double WithinBand(double usage, double bottom, double top)
{
    return usage > bottom ? Math.min(usage, 200) - bottom : 0;
}
```



Ȼ������һ����

```csharp
private double WithinBand(double usage, double bottom, double top)
{
    return usage > bottom ? Math.min(usage, top) - bottom : 0;
}
```



����ԭ������ bottomBand �����ĵط����ҽ����Ϊ���ò������˵��º�����

```csharp
public Dollars BaseCharge(double usage)
{
    if (usage < 0)
    {
        return new Dollars(0);
    }

    double amount = WithinBand(usage, 0, 100) * 0.03 + WithinBand(usage, 100, 200) * 0.05
        + TopBand(usage) * 0.07;
    return new Dollars(amount);
}

private double BottomBand(usage) {
	return Math.min(usage, 100);
}
```



Ϊ���滻�� topBand �ĵ��ã��Ҿ͵��ô�������󡱵� Infinity ��Ϊ�����Χ���Ͻ硣

```csharp
public Dollars BaseCharge(double usage)
{
    if (usage < 0)
    {
        return new Dollars(0);
    }

    double amount = WithinBand(usage, 0, 100) * 0.03 + WithinBand(usage, 100, 200) * 0.05
        + WithinBand(usage, 200, double.PositiveInfinity) * 0.07;
    return new Dollars(amount);
}

private double TopBand(usage) {
	return usage > 200 ? usage - 200 : 0;
}
```

�����ڵ��߼���baseCharge һ��ʼ��������Ѿ�����ȥ���ˡ�������������������Ѿ�ʧȥ���߼��ϵı�Ҫ�ԣ��һ���Ը���������ԭ�أ���Ϊ�������ˡ������ usage ����Ϊ�����������������δ���ġ�
