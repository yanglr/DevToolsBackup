## 令函数携带参数（Parameterize Method）

**函数参数化**

在尝试对几个相关的函数做参数化操作时，我会先从中挑选一个，在上面添加参数，同时留意其他几种情况。在类似这样处理“范围”的情况下，通常从位于中间的范围开始着手较好。所以我首先选择了 middleBand 函数来添加参数，然后调整其他的调用者来适应它。

middleBand 使用了两个字面量值，即 100 和 200，分别代表“中间档次”的下界和上界。我首先用改变函数声明（124）加上这两个参数，同时顺手给函数改个名，使其更好地表述参数化之后的含义。

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



在函数体内部，把一个字面量改为使用新传入的参数：

```csharp
private double WithinBand(double usage, double bottom, double top)
{
    return usage > bottom ? Math.min(usage, 200) - bottom : 0;
}
```



然后是另一个：

```csharp
private double WithinBand(double usage, double bottom, double top)
{
    return usage > bottom ? Math.min(usage, top) - bottom : 0;
}
```



对于原本调用 bottomBand 函数的地方，我将其改为调用参数化了的新函数。

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



为了替换对 topBand 的调用，我就得用代表“无穷大”的 Infinity 作为这个范围的上界。

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

照现在的逻辑，baseCharge 一开始的卫语句已经可以去掉了。不过，尽管这条语句已经失去了逻辑上的必要性，我还是愿意把它留在原地，因为它阐明了“传入的 usage 参数为负数”这种情况是如何处理的。
