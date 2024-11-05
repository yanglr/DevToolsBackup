## 6.Remove Middle Man

### �Ƴ��м���

һ��������̫��򵥵�ί�С�

�ÿͻ���ֱ�ӵ���ί�С�

#### �ŵ�

+ **�������**��ͨ���ÿͻ���ֱ�ӵ���ί���࣬���Լ�����֮�����ϡ�
+ **�������**�����ٲ���Ҫ���м���ã�������ߴ����ִ��Ч�ʡ�
+ **�򻯴���**���Ƴ�����Ҫ���м��ˣ�����ʹ�����������ˡ�

#### ����

+ **��¶�ڲ��ṹ**���ÿͻ���ֱ�ӵ���ί���࣬���ܻᱩ¶����ڲ��ṹ������ά���Ѷȡ�
+ **���Ӹ�����**�������С�Ĵ������ܻ����Ӵ���ĸ����ԣ��ر��ǵ���Ҫ����ĳЩʵ��ϸ��ʱ��

#### ʾ��

���Ǵ�һ�����ز��ŵ� `Person` ���һ�� `Department` �࿪ʼ��

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

Ҫ�ҵ�ĳ�˵ľ����ͻ�����Ҫ�������ã�

```java
manager = john.getManager();
```

��ܼ����ã����ҷ�װ�˲��š�Ȼ��������кܶ෽���������������ջ��� `Person` ���г���̫��򵥵�ί�С���ʱ����Ҫ�Ƴ��м��ˡ����ȣ�����Ϊί�д���һ����������

```java
class Person {
    Department _department;

    public Department getDepartment() {
        return _department;
    }
}
```

Ȼ������������������ҵ�ʹ�� `Person` �����Ŀͻ��ˣ�������Ϊ���Ȼ�ȡί�У�Ȼ��ʹ������

```java
manager = john.getDepartment().getManager();
```

Ȼ�����ǿ��Դ� `Person` �����Ƴ� `getManager` ���������������ʾ�Ƿ���©���κεط���



### C# ����

�������ǽ���������ת��ΪC#���룬����ӱ�Ҫ��ģ���ࡣ

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

���������Ǿ�����˽����Ƴ��м��ˡ�������ʾ�����뷭������Ĳ�ת��ΪC#���롣



��������һ�´����еı�������

1. **_department**: ����һ�� `Department` ���ʵ�������ڱ�ʾһ���˵Ĳ��š����������벿����ص���Ϣ�����粿�ž���
2. **_manager**: ����һ�� `Person` ���ʵ�������ڱ�ʾ���ŵľ���
3. **Department**: ����һ�����ԣ����ڷ��ʺ����� `Person` ���е� `_department` ���������ṩ��һ����װ�ķ�ʽ������������Ϣ��
4. **Manager**: ����һ�����ԣ����ڷ��ʺ����� `Department` ���е� `_manager` ���������ṩ��һ����װ�ķ�ʽ������������Ϣ��
5. **GetManager**: ����һ�����������ڷ��ز��ŵľ�����ͨ������ `_department` �� `Manager` ��������ȡ������Ϣ��

ͨ����Щ�����ͷ��������ǿ��Ը�������������Ľṹ�͹��ܡ�