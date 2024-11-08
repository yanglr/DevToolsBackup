## 8.Introduce Local Extension

### 引入本地扩展

C#: 有专门的 extension method



你正在使用的服务器类需要几个额外的方法，但你不能修改该类。

创建一个包含这些额外方法的新类。使这个扩展类成为原始类的子类或包装类。


#### 动机

类的作者并非全知全能，他们可能没有为你提供有用的方法。如果你可以修改源代码，通常最好的方法是添加该方法。然而，你通常不能修改源代码。如果你只需要一两个方法，可以使用引入外来方法（Introduce Foreign Method）。但是，一旦你需要的方法超过几个，它们就会变得难以管理。因此，你需要将这些方法分组到一个合理的位置。标准的面向对象技术，如子类化和包装，是实现这一目标的明显方法。在这种情况下，我称子类或包装类为本地扩展。

本地扩展是一个独立的类，但它是所扩展类的子类型。这意味着它支持原始类的所有功能，并且还添加了额外的功能。你可以实例化本地扩展并使用它，而不是使用原始类。

通过使用本地扩展，你可以遵循将方法和数据打包成良好单元的原则。如果你不断将代码放入其他类中，而这些代码应该在扩展中，你最终会使其他类复杂化，并使这些方法难以重用。

在选择子类和包装类之间时，我通常更喜欢子类，因为它的工作量较少。子类的最大障碍是它需要在对象创建时应用。如果我可以接管创建过程，那就没问题。如果你在稍后应用本地扩展，问题就出现了。子类化迫使我创建该子类的新对象。如果其他对象引用旧对象，我就有两个具有原始数据的对象。如果原始对象是不可变的，那就没问题；我可以安全地复制它。但如果原始对象可以更改，就会有问题，因为一个对象的更改不会影响另一个对象，我必须使用包装类。这样，通过本地扩展进行的更改会影响原始对象，反之亦然。

#### 优点

+ **增强功能**：可以在不修改原始类的情况下添加所需的功能。
+ **减少重复代码**：通过将额外的方法集中在一个扩展类中，可以减少代码重复。
+ **提高代码可维护性**：将相关的方法集中在一个类中，使代码更易于维护和理解。

#### 限制

+ **增加复杂性**：引入本地扩展可能会增加代码的复杂性，特别是在处理包装类时。
+ **依赖性问题**：如果原始类发生变化，可能需要更新所有使用本地扩展的代码。

### 示例：使用子类

首先，我创建一个新的日期子类：

```java
class MfDateSub extends Date
```

接下来，我处理日期和扩展之间的转换。原始类的构造函数需要用简单的委托来重复：

```java
public MfDateSub(String dateString) {
    super(dateString);
}
```

现在，我添加一个转换构造函数，它接受一个原始对象作为参数：

```java
public MfDateSub(Date arg) {
    super(arg.getTime());
}
```

现在，我可以向扩展添加新功能，并使用移动方法（Move Method）将任何外来方法移到扩展中：

```java
client class...
private static Date nextDay(Date arg) {
    // foreign method, should be on date
    return new Date(arg.getYear(), arg.getMonth(), arg.getDate() + 1);
}

becomes

class MfDateSub...
Date nextDay() {
    return new Date(getYear(), getMonth(), getDate() + 1);
}
```

### 示例：使用包装类

首先，我声明包装类：

```java
class mfDateWrap {
    private Date _original;
}
```

使用包装方法时，我需要以不同的方式设置构造函数。原始构造函数通过简单的委托实现：

```java
public MfDateWrap(String dateString) {
    _original = new Date(dateString);
}
```

转换构造函数现在只设置实例变量：

```java
public MfDateWrap(Date arg) {
    _original = arg;
}
```

然后是委托原始类所有方法的繁琐任务。我只展示几个：

```java
public int getYear() {
    return _original.getYear();
}

public boolean equals(Object arg) {
    if (this == arg) return true;
    if (!(arg instanceof MfDateWrap)) return false;
    MfDateWrap other = (MfDateWrap) arg;
    return _original.equals(other._original);
}
```

完成这些后，我可以使用移动方法（Move Method）将日期特定的行为放到新类中：

```java
client class...
private static Date nextDay(Date arg) {
    // foreign method, should be on date
    return new Date(arg.getYear(), arg.getMonth(), arg.getDate() + 1);
}

becomes

class MfDateWrap...
Date nextDay() {
    return new Date(getYear(), getMonth(), getDate() + 1);
}
```

### C# 代码

现在我们将上述代码转换为C#代码，并添加必要的模型类。

#### 使用子类(继承)的示例

```java
using System;

public class MfDateSub : DateTime {
    public MfDateSub(string dateString) : base(DateTime.Parse(dateString).Ticks) { }

    public MfDateSub(DateTime arg) : base(arg.Ticks) { }

    public DateTime NextDay() {
        return new DateTime(Year, Month, Day + 1);
    }
}

public class Program {
    public static void Main() {
        DateTime previousEnd = new DateTime(2023, 10, 21);
        MfDateSub newDate = new MfDateSub(previousEnd);
        DateTime nextDay = newDate.NextDay();

        Console.WriteLine(nextDay.ToString("yyyy-MM-dd"));
    }
}
```

#### 使用包装类(装饰器模式)的示例

```java
using System;

public class MfDateWrap {
    private DateTime _original;

    public MfDateWrap(string dateString) {
        _original = DateTime.Parse(dateString);
    }

    public MfDateWrap(DateTime arg) {
        _original = arg;
    }

    public int Year {
        get { return _original.Year; }
    }

    public int Month {
        get { return _original.Month; }
    }

    public int Day {
        get { return _original.Day; }
    }

    public DateTime NextDay() {
        return new DateTime(Year, Month, Day + 1);
    }

    public override bool Equals(object obj) {
        if (this == obj) return true;
        if (!(obj is MfDateWrap)) return false;
        MfDateWrap other = (MfDateWrap)obj;
        return _original.Equals(other._original);
    }
}

public class Program {
    public static void Main() {
        DateTime previousEnd = new DateTime(2023, 10, 21);
        MfDateWrap newDate = new MfDateWrap(previousEnd);
        DateTime nextDay = newDate.NextDay();

        Console.WriteLine(nextDay.ToString("yyyy-MM-dd"));
    }
}
```

这样，我们就完成了将“引入本地扩展”技术的示例代码翻译成中文并转换为C#代码。



当然，我来解释一下代码中的变量名：

### 使用子类的示例

1. **previousEnd**: 这是一个 `DateTime` 类型的变量，用于存储上一个计费周期的结束日期。
2. **newDate**: 这是一个 `MfDateSub` 类的实例，用于表示扩展后的日期对象。
3. **nextDay**: 这是一个 `DateTime` 类型的变量，用于存储计算后的下一天的日期。
4. **MfDateSub**: 这是一个继承自 `DateTime` 的子类，添加了额外的方法，如 `NextDay`。
5. **NextDay**: 这是 `MfDateSub` 类中的一个方法，用于计算给定日期的下一天。

### 使用包装类的示例

1. **_original**: 这是一个 `DateTime` 类型的变量，用于存储原始的日期对象。
2. **Year**: 这是一个属性，用于获取 `_original` 日期对象的年份。
3. **Month**: 这是一个属性，用于获取 `_original` 日期对象的月份。
4. **Day**: 这是一个属性，用于获取 `_original` 日期对象的日期。
5. **NextDay**: 这是 `MfDateWrap` 类中的一个方法，用于计算给定日期的下一天。
6. **Equals**: 这是 `MfDateWrap` 类中的一个方法，用于比较两个 `MfDateWrap` 对象是否相等。

通过这些变量和方法，我们可以更清晰地理解代码的结构和功能。

### 使用扩展函数 (C#)

```cs
DateTime NextDay(this DateTime date);
```

C# 例子, 改写自: https://ctrlshift.dev/introduce-local-extension/
