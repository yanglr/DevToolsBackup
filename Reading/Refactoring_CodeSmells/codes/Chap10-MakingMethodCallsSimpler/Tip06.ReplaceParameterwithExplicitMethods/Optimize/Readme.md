# 10.6 Replace Parameter with Explicit Methods (以明确函数取代参数) 

你有一个函数, 其中完全取决于参数值而采取不同行为。
**针对该参数的每一个可能值, 建立一个独立函数。**



```java
void setValue (String name, int value) {
    if (name.equals("height"))
        _height = value;
    if (name.equals("width"))
        _width = value;
    Assert.shouldNeverReachHere();
}
```


↓


```java
void setHeight(int arg) {
    _height = arg;
}

void setWidth (int arg) {
    _width = arg;
}
```



## 动机
Replace Parameter with Explicit Methods (285)恰恰相反于Parameterize Method (283)。如果某个参数有多种可能的值, 而函数内又以条件表达式检查这些参数值, 并根据不同参数值做出不同的行为, 那么就应该使用本项重构。调用者原本必须赋予参数适当的值, 以决定该函数做出何种响应。现在, 既然你提供了不同的函数给调用者使用, 就可以避免出现条件表达式。此外你还可以获得编译期检查的好处, 而且接口也更清楚。如果以参数值决定函数行为, 那么函数用户不但需要观察该函数, 而且还要判断参数值是否合法, 而 “合法的参数值” 往往很少在文档中被清楚地提出。 

就算不考虑编译期检查的好处, 只是为了获得一个清晰的接口, 也值得你执行本项重构。哪怕只是给一个内部的布尔变量赋值, 相较之下, Switch.beOn () 也比 Switch. setState (true) 要清楚得多。
但是, 如果参数值不会对函数行为有太多影响, 你就不应该使用Replace Parameter with Explicit Methods (285)。如果情况真是这样, 而你也只需要通过参数为一个字段赋值, 那么直接使用设值函数就行了。如果的确需要条件判断的行为, 可考虑使用Replace Conditional with Polymorphism (255)。

## 做法

- 针对参数的每一种可能值, 新建一个明确函数。

- 修改条件表达式的每个分支, 使其调用合适的新函数。

- 修改每个分支后, 编译并测试。

- 修改原函数的每一个被调用点, 改而调用上述的某个合适的新函数。

- 编译, 测试。

- 所有调用端都修改完毕后, 删除原函数。

**范例**
下列代码中, 我想根据不同的参数值, 建立Employee之下不同的子类。以下代码往往是Replace Constructor with Factory Method (304)的施行成果:



```cs
    internal class Employee
    {
        internal static Employee Create(int type)
        {
            switch (type)
            {
                case Constants.Engineer:
                    return new Engineer();

                case Constants.Salesman:
                    return new Salesman();

                case Constants.Manager:
                    return new Manager();

                default:
                    throw new ArgumentException("Incorrect type code value");
            }
        }
    }
```



由于这是一个工厂函数, 我不能实施Replace Conditional with Polymorphism (255), 因为使用该函数时对象根本还没创建出来。由于可以预见到 Employee不会有太多新的子类, 所以我可以放心地为每个子类建立一个工厂函数, 而不必担心工厂函数的数量会剧增。

首先, 我要根据参数值建立相应的新函数: 



```cs
    internal class Employee
    {
        internal static Employee CreateEngineer()
        {
            return new Engineer();
        }

        internal static Employee CreateSalesman()
        {
            return new Salesman();
        }

        internal static Employee CreateManager()
        {
            return new Manager();
        }
    }
```



然后把switch语句的各个分支替换为对新函数的调用:



```cs
internal static Employee create(int type) {
    switch (type) {
        case ENGINEER:
            return Employee.createEngineer();
        case SALESMAN:
            return new Salesman();
        case MANAGER:
            return new Manager();
        default:
            throw new ArgumentException("Incorrect type code value");
    }
}
```




每修改一个分支, 都需要编译并测试, 直到所有分支修改完毕为止:

```cs
        private static Employee Create(int type)
        {
            switch (type)
            {
                case Constants.Engineer:
                    return CreateEngineer();

                case Constants.Salesman:
                    return CreateSalesman();

                case Constants.Manager:
                    return CreateManager();

                default:
                    throw new ArgumentException("Incorrect type code value");
            }
        }
```



接下来, 我把注意力转移到旧函数的调用端。我把诸如下面这样的代码:


```cs
            Employee kent = Employee.Create(Constants.Engineer);
```



替换为:

```cs
            Employee kent = Employee.CreateManager();
```



修改完Create () 函数的所有调用者之后, 就可以把create ( ) 函数删掉了。同时也可以把所有常量都删掉。

