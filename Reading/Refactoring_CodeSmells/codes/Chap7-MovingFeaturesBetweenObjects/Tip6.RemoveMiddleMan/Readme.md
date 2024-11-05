## 6.Remove Middle Man

### 移除中间人

一个类在做太多简单的委托。

让客户端直接调用委托。

#### 优点

+ **减少耦合**：通过让客户端直接调用委托类，可以减少类之间的耦合。
+ **提高性能**：减少不必要的中间调用，可以提高代码的执行效率。
+ **简化代码**：移除不必要的中间人，可以使代码更简洁明了。

#### 限制

+ **暴露内部结构**：让客户端直接调用委托类，可能会暴露类的内部结构，增加维护难度。
+ **增加复杂性**：如果不小心处理，可能会增加代码的复杂性，特别是当需要隐藏某些实现细节时。

#### 示例

我们从一个隐藏部门的 `Person` 类和一个 `Department` 类开始：

```java
class Person {
    Department _department;

    public Person getManager() {
        return _department.getManager();
    }
}

class Department {
    private Person _manager;

    public Department(Person manager) {
        _manager = manager;
    }

    public Person getManager() {
        return _manager;
    }
}
```

要找到某人的经理，客户端需要这样调用：

```java
manager = john.getManager();
```

这很简单易用，并且封装了部门。然而，如果有很多方法都这样做，最终会在 `Person` 类中出现太多简单的委托。这时就需要移除中间人。首先，我们为委托创建一个访问器：

```java
class Person {
    Department _department;

    public Department getDepartment() {
        return _department;
    }
}
```

然后我们逐个方法处理。找到使用 `Person` 方法的客户端，并更改为首先获取委托，然后使用它：

```java
manager = john.getDepartment().getManager();
```

然后我们可以从 `Person` 类中移除 `getManager` 方法。编译可以显示是否遗漏了任何地方。



### C# 代码

现在我们将上述代码转换为C#代码，并添加必要的模型类。

```java
public class Person {
    private Department _department;

    public Department Department {
        get { return _department; }
        set { _department = value; }
    }

    public Person GetManager() {
        return _department.Manager;
    }
}

public class Department {
    private Person _manager;

    public Department(Person manager) {
        _manager = manager;
    }

    public Person Manager {
        get { return _manager; }
        set { _manager = value; }
    }
}
```

这样，我们就完成了将“移除中间人”技术的示例代码翻译成中文并转换为C#代码。



我来解释一下代码中的变量名：

1. **_department**: 这是一个 `Department` 类的实例，用于表示一个人的部门。它包含了与部门相关的信息，例如部门经理。
2. **_manager**: 这是一个 `Person` 类的实例，用于表示部门的经理。
3. **Department**: 这是一个属性，用于访问和设置 `Person` 类中的 `_department` 变量。它提供了一个封装的方式来操作部门信息。
4. **Manager**: 这是一个属性，用于访问和设置 `Department` 类中的 `_manager` 变量。它提供了一个封装的方式来操作经理信息。
5. **GetManager**: 这是一个方法，用于返回部门的经理。它通过调用 `_department` 的 `Manager` 属性来获取经理信息。

通过这些变量和方法，我们可以更清晰地理解代码的结构和功能。