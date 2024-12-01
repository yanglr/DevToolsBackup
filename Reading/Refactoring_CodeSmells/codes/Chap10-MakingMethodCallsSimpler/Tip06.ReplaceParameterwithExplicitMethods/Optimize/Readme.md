# 10.6 Replace Parameter with Explicit Methods (����ȷ����ȡ������) 

����һ������, ������ȫȡ���ڲ���ֵ����ȡ��ͬ��Ϊ��
**��Ըò�����ÿһ������ֵ, ����һ������������**



```java
void setValue (String name, int value) {
    if (name.equals("height"))
        _height = value;
    if (name.equals("width"))
        _width = value;
    Assert.shouldNeverReachHere();
}
```


��


```java
void setHeight(int arg) {
    _height = arg;
}

void setWidth (int arg) {
    _width = arg;
}
```



## ����
Replace Parameter with Explicit Methods (285)ǡǡ�෴��Parameterize Method (283)�����ĳ�������ж��ֿ��ܵ�ֵ, �������������������ʽ�����Щ����ֵ, �����ݲ�ͬ����ֵ������ͬ����Ϊ, ��ô��Ӧ��ʹ�ñ����ع���������ԭ�����븳������ʵ���ֵ, �Ծ����ú�������������Ӧ������, ��Ȼ���ṩ�˲�ͬ�ĺ�����������ʹ��, �Ϳ��Ա�������������ʽ�������㻹���Ի�ñ����ڼ��ĺô�, ���ҽӿ�Ҳ�����������Բ���ֵ����������Ϊ, ��ô�����û�������Ҫ�۲�ú���, ���һ�Ҫ�жϲ���ֵ�Ƿ�Ϸ�, �� ���Ϸ��Ĳ���ֵ�� �����������ĵ��б����������� 

���㲻���Ǳ����ڼ��ĺô�, ֻ��Ϊ�˻��һ�������Ľӿ�, Ҳֵ����ִ�б����ع�������ֻ�Ǹ�һ���ڲ��Ĳ���������ֵ, ���֮��, Switch.beOn () Ҳ�� Switch. setState (true) Ҫ����öࡣ
����, �������ֵ����Ժ�����Ϊ��̫��Ӱ��, ��Ͳ�Ӧ��ʹ��Replace Parameter with Explicit Methods (285)����������������, ����Ҳֻ��Ҫͨ������Ϊһ���ֶθ�ֵ, ��ôֱ��ʹ����ֵ���������ˡ������ȷ��Ҫ�����жϵ���Ϊ, �ɿ���ʹ��Replace Conditional with Polymorphism (255)��

## ����

- ��Բ�����ÿһ�ֿ���ֵ, �½�һ����ȷ������

- �޸��������ʽ��ÿ����֧, ʹ����ú��ʵ��º�����

- �޸�ÿ����֧��, ���벢���ԡ�

- �޸�ԭ������ÿһ�������õ�, �Ķ�����������ĳ�����ʵ��º�����

- ����, ���ԡ�

- ���е��ö˶��޸���Ϻ�, ɾ��ԭ������

**����**
���д�����, ������ݲ�ͬ�Ĳ���ֵ, ����Employee֮�²�ͬ�����ࡣ���´���������Replace Constructor with Factory Method (304)��ʩ�гɹ�:



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



��������һ����������, �Ҳ���ʵʩReplace Conditional with Polymorphism (255), ��Ϊʹ�øú���ʱ���������û�������������ڿ���Ԥ���� Employee������̫���µ�����, �����ҿ��Է��ĵ�Ϊÿ�����ཨ��һ����������, �����ص��Ĺ��������������������

����, ��Ҫ���ݲ���ֵ������Ӧ���º���: 



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



Ȼ���switch���ĸ�����֧�滻Ϊ���º����ĵ���:



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




ÿ�޸�һ����֧, ����Ҫ���벢����, ֱ�����з�֧�޸����Ϊֹ:

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



������, �Ұ�ע����ת�Ƶ��ɺ����ĵ��öˡ��Ұ��������������Ĵ���:


```cs
            Employee kent = Employee.Create(Constants.Engineer);
```



�滻Ϊ:

```cs
            Employee kent = Employee.CreateManager();
```



�޸���Create () ���������е�����֮��, �Ϳ��԰�create ( ) ����ɾ���ˡ�ͬʱҲ���԰����г�����ɾ����

